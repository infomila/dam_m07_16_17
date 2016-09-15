using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLlenguatgeCS
{
    class Persona
    {
        private string nom ="Paco";

        public Persona()
        {
            string nom = "Maria";

            string copia = nom; // "Maria"
            string copia1 = this.nom;  // "Paco"
            
        }
    }
}
