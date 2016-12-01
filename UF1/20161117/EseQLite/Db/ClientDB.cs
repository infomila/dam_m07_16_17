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
    class ClientDB
    {
        public static Client getClient( string pNIF)
        {

            using (HotelContext ctx = new HotelContext())
            {

                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        string sql = "select * from client  where cli_NIF=:NIF";
 
                        command.CommandText = sql;
                        DBUtil.addParameter(command, "NIF", pNIF);

                        DbDataReader reader = command.ExecuteReader();

                        if (!reader.Read()) return null;
                         
                        string NIF = reader.GetString(reader.GetOrdinal("cli_NIF"));
                        string nomClient = reader.GetString(reader.GetOrdinal("cli_nom"));
                        string poblacio = reader.GetString(reader.GetOrdinal("cli_poblacio"));
                         
                        DateTime dataNaix = reader.GetDateTime(reader.GetOrdinal("cli_data_naix"));



                        return new Client(NIF, nomClient, poblacio, dataNaix);

                        }
                    }
                }
            }
        }// end class
    }// end namespace
   