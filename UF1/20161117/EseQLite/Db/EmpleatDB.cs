using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Db
{
    class EmpleatDB
    {

        public static string consulta( string sql )
        {

            using (EmpresaContext ctx = new EmpresaContext())
            {
                //Get student name of string type
                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "select * from emp";
                        DbDataReader reader = command.ExecuteReader();
                        string res = "";
                        while (reader.Read())
                        {
                            Int64 id = reader.GetInt64(reader.GetOrdinal("id"));
                            string nom = reader.GetString(reader.GetOrdinal("nom"));
                            res += ("id:" + id + ", nom:" + nom + "\n");

                        }

                        return res;

                    }
                }
            }
        }


        public Int64 getNumeroEmpleats()
        {

            using (EmpresaContext ctx = new EmpresaContext())
            {
                //Get student name of string type
                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "select count(*) from emp";
                        var count = command.ExecuteScalar();
                        return (Int64)count;

                    }
                }
            }
            return 0;
        }
    }
}