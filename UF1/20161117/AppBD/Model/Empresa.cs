using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AppBD.Model
{
    /*protected SQLiteAsyncConnection GetConnection(string dbName)
    {
        // dbName = 'hoge.db'	
        // pool is acquired by ' new SQLiteConnectionPool(new   SQLitePlatformWinRT());'
        if (null == pool) { return null; }
        return new SQLiteAsyncConnection(() => pool.GetConnection(new SQLiteConnectionString(ApplicationData.Current.LocalFolder.Path + "\\" + dbName, false)));
    }*/

    public class EmpresaContext : DbContext
    {
        public DbSet<Empleat> Blogs { get; set; }
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=emp.db");
        }        
    }

    public class Empleat
    {

        //public static ObservableCollection<string> getEmpleats()
        public static int getEmpleats()
        {
            using (var ctx = new EmpresaContext())
            {
                //Get student name of string type
                using ( var connection  = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {

                        //command.CommandText = "insert into emp values ( (SELECT COUNT(*)+1 FROM emp), 'Bartolomeu' );";
                        //int rowInserted = command.ExecuteNonQuery();

                        command.CommandText = "SELECT * FROM emp";       
                                         
                    }
                }
             }
            return 0;
        }

        private string mNom;

        public string Nom
        {
            get { return mNom; }
            set { mNom = value; }
        }

    }
}
