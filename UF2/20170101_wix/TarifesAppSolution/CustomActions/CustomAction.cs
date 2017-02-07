using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using System.Threading;

namespace CustomActions
{
    public class CustomActions
    {
        static Thread _t;
        static ManualResetEvent _done = new ManualResetEvent(false);
        static ActionResult _r;
        [CustomAction]
        public static ActionResult MostrarPantalla(Session session)
        {
            session.Log("Begin CustomAction1");

            _t = new Thread(WorkerThread);
            _t.SetApartmentState(ApartmentState.STA);
            _t.Start();
            _done.WaitOne();

            return _r;
        }

        [STAThread] 
        static void WorkerThread()
        {
            try
            {
                Dialeg d = new Dialeg();
                bool? ok = d.ShowDialog();
                if(ok.HasValue && ok.Value)
                {
                    _r = ActionResult.Success;
                } else
                {
                    _r = ActionResult.Failure;
                }
                
            }
            finally
            {
                _done.Set();
            }
        }
    }
}
