using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExempleBaseInstallador;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Persona p = new Persona();
            p.crida(9);
            p.crida(7);
        }
    }
}
