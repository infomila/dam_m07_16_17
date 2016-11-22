using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Db
{
    class HotelDB
    {

        public static string getHotels()
        {

            using (HotelContext ctx = new HotelContext())
            {

                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "select * from hotel";
                        DbDataReader reader = command.ExecuteReader();
                        string res = "";
                        while (reader.Read())
                        {
                            Int64 id = reader.GetInt64(reader.GetOrdinal("htl_codi"));
                            string nom = reader.GetString(reader.GetOrdinal("htl_nom"));
                            res += ("id:" + id + ", nom:" + nom + "\n");

                        }

                        return res;

                    }
                }
            }
        }


        public Int64 getNumeroHotels()
        {

            using (HotelContext ctx = new HotelContext())
            {
                //Get student name of string type
                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "select count(*) from hotel";
                        var count = command.ExecuteScalar();
                        return (Int64)count;
                    }
                }
            }
            return 0;
        }
    }
}