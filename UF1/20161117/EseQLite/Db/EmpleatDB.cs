using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Db
{
    class EmpleatDB
    {
        public int getNumeroEmpleats()
        {

            using (EmpresaContext ctx = new EmpresaContext())
            {
                //Get student name of string type
                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                    }
                }
            }
            return 0;
        }
    }
}