using EseQLite.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Db
{
    class HabitacioDB
    {


        public static void alliberaHabitacio(Int64 pCodiHotel, Int64 pNumHab )
        {
            marcaHabitacio(pCodiHotel, pNumHab, null, DateTime.Now);
        }

        public static void ocupaHabitacio(Int64 pCodiHotel, Int64 pNumHab, string pNIF, DateTime pDataEntrada)
        {
            marcaHabitacio(pCodiHotel, pNumHab, pNIF, pDataEntrada);
        }

        private static void marcaHabitacio(Int64 pCodiHotel, Int64 pNumHab, string pNIF, DateTime pDataEntrada) { 

            using (HotelContext ctx = new HotelContext())
            {
                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();
                    //DbTransaction trans = connection.BeginTransaction();           
                    using (var command = connection.CreateCommand())
                    {                        
                        try
                        {                            
                            string sql = "update habitacio set hab_cli_NIF=:NIF , hab_data_entrada=:data_entrada where hab_htl_codi=:codiHotel and hab_numero=:numHabitacio";
                            command.CommandText = sql;

                            if (pNIF == null)
                            {
                                DBUtil.addParameter(command, "NIF", DBNull.Value);
                                DBUtil.addParameter(command, "data_entrada", DBNull.Value);
                            }
                            else
                            {
                                DBUtil.addParameter(command, "NIF", pNIF);
                                DBUtil.addParameter(command, "data_entrada", pDataEntrada);
                            }
                            DBUtil.addParameter(command, "codiHotel", pCodiHotel);
                            DBUtil.addParameter(command, "numHabitacio", pNumHab);

                            //command.Transaction = trans;

                            int filesModificades = command.ExecuteNonQuery();
                            if (filesModificades != 1) throw new Exception("Error ocupant habitació");

                            //trans.Commit();
                        }
                        catch(Exception ex)
                        {
                            //if(trans!=null) trans.Rollback();
                            throw new Exception("Error ocupant habitació");
                        }
                    }
                }
            }

        }

        public static List<Habitacio> getHabitacions(Int64 pCodiHotel, bool lliures)
        {
            List<Habitacio> habitacions = new List<Habitacio>();

            using (HotelContext ctx = new HotelContext())
            {

                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        
                        string sql = "select * from habitacio h left outer join client c on cli_NIF=hab_cli_NIF where hab_htl_codi=:codiHotel";
                        if (lliures)
                        {
                            sql += " and cli_NIF is null";
                        } else
                        {
                            sql += " and cli_NIF is not null";
                        }
                        command.CommandText = sql;
                        DBUtil.addParameter(command, "codiHotel", pCodiHotel);

                        DbDataReader reader = command.ExecuteReader();
                        /*
                            hab_htl_codi decimal(10),
                            hab_numero decimal(10),
                            hab_cli_NIF char(9),
                            hab_data_entrada date,
                            hab_max_persones decimal(1),
                            hab_planta decimal(2),
                         */
                        while (reader.Read())
                        {
                            Int64 codi = reader.GetInt64(reader.GetOrdinal("hab_htl_codi"));
                            Int64 num = reader.GetInt64(reader.GetOrdinal("hab_numero"));
                            string NIF = null;
                            string nomClient = null;
                            if (!reader.IsDBNull(reader.GetOrdinal("hab_cli_NIF")))
                            {
                                NIF = reader.GetString(reader.GetOrdinal("hab_cli_NIF"));
                                nomClient = reader.GetString(reader.GetOrdinal("cli_nom"));
                            }
                            DateTime? dataEntrada = null;
                            if (!reader.IsDBNull(reader.GetOrdinal("hab_data_entrada")))
                            {
                                dataEntrada = reader.GetDateTime(reader.GetOrdinal("hab_data_entrada"));
                            }
                            Int32 capacitat = reader.GetInt32(reader.GetOrdinal("hab_max_persones"));
                            Int32 planta = reader.GetInt32(reader.GetOrdinal("hab_planta"));



                            Habitacio h = new Habitacio(codi, num, NIF, nomClient, dataEntrada, capacitat, planta);
                            habitacions.Add(h);
                        }
                    }
                }
            }
            return habitacions;
        }



    }
}
