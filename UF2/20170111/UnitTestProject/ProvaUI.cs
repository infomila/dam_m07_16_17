using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace UnitTestProject
{

    [TestClass]
    public class ProvaUI
    {
        [TestMethod]
        public void provarSeleccioPersona()
        {

            string ruta = System.AppDomain.CurrentDomain.BaseDirectory;
            
            ruta += @"\..\..\..\DemoUnitTesting\bin\Debug\DemoUnitTesting.exe";

            Console.WriteLine(ruta);
 

             Application application = Application.Launch(ruta);
            //Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            Window window = application.GetWindows()[0];

            ListView l = window.Get<ListView>("dtgPersones");
            l.Rows[1].Cells[0].Click();

            Button b = window.Get<Button>("btnOk");
            b.Click();

            TextBox t = window.Get<TextBox>("txtNom");
            Assert.AreEqual(l.Rows[1].Cells[1].Text, t.Text);

            application.Close();
        }

        [TestMethod]
        public void xxxx()
        {

            string ruta = System.AppDomain.CurrentDomain.BaseDirectory;

            ruta += @"\..\..\..\DemoUnitTesting\bin\Debug\DemoUnitTesting.exe";

            Console.WriteLine(ruta);


            Application application = Application.Launch(ruta);
            //Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            Window window = application.GetWindows()[0];

            ListView l = window.Get<ListView>("dtgPersones");
            l.Rows[1].Cells[0].Click();

            Button b = window.Get<Button>("btnOk");
            b.Click();

            TextBox t = window.Get<TextBox>("txtNom");
            Assert.AreEqual(l.Rows[1].Cells[1].Text, t.Text);

            application.Close();
        }





    }
}
