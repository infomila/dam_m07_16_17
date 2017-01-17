using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoUnitTesting.Model;

namespace UnitTestProject
{
    [TestClass]
    public class PersonaTest
    {
        [TestMethod]
        public void provaConstructor()
        {
            DateTime d = DateTime.Now;
            Persona p = new Persona("11111111H", "Paco", "Jones", d);
            Assert.AreEqual("Paco", p.Nom);
            Assert.AreEqual("Jones", p.Cognoms);
            Assert.AreEqual("11111111H", p.NIF);
            Assert.AreEqual(d, p.DataNaix);
        }

        [TestMethod]
        public void gestioAdreces()
        {
            DateTime d = DateTime.Now;

            Persona p = new Persona("11111111H", "Paco", "Jones", d);

            Adreca a = p.getAdreca(0);
            Assert.IsNull(a);

            Adreca casaMeva = new Adreca("Carrer", "Dels Semàfors", "33", "2-2", "");
            Adreca casaMevaClonic = new Adreca("Carrer", "Dels Semàfors", "33", "2-2", "");
            Assert.IsTrue(p.addAdreca(casaMeva));
            Assert.AreEqual(1, p.getNumAdreces());
            Assert.IsFalse(p.addAdreca(casaMevaClonic));
            Assert.AreEqual(1, p.getNumAdreces());

            bool haLlancatExcepcio = false;
            try
            {
                p.addAdreca(null); // Això ha de petar
                //---------------- aquí no hi hauríem de ser!!!                
            }
            catch (Exception e)
            {
                haLlancatExcepcio = true;
            }
            if(!haLlancatExcepcio)
            {
                Assert.Fail("Ha de petar quan posem adreces nul·les");
            }
        }

    }
}
