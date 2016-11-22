using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Db
{
    class HotelContext : DbContext
    {
        /// <summary>
        /// Propietat que conté el nom 
        /// de l'arxiu de la base de dades
        /// </summary>
        public static string DBFileName
        {
            get
            {
                return "hotel.db";
            }
        }
        

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename="+HotelContext.DBFileName);
        }
    }
}
