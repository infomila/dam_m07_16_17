using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Db
{
    class DBUtil
    {
        public static void addParameter<T>(DbCommand command, string name, T valor)
        {
            DbParameter param = command.CreateParameter();
            param.ParameterName = name;
            param.Value = valor;

            command.Parameters.Add(param);
        }

        
    }
}
