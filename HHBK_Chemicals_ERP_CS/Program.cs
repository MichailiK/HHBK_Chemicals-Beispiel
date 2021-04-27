using System;
using System.Linq;
using System.Windows.Forms;
using HHBK_Chemicals_ERP_CS.Datenbank;
using HHBK_Chemicals_ERP_CS.Main;

namespace HHBK_Chemicals_ERP_CS
{
    internal static class Program
    {
        /// <summary>
        ///     Der Haupteinstiegspunkt für die Anwendung
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var datenbank = new FakeDatenbank();

            if (args.Contains("--legacyview"))
            {
                var viewMain = new LegacyMain.ViewMain();
                var controllerMain = new LegacyMain.ControllerMain();
                var modelMain = new LegacyMain.ModelMain(datenbank);

                viewMain.Controller = controllerMain;
                controllerMain.ModelMain = modelMain;
                modelMain.ViewMain = viewMain;

                Application.Run(viewMain);
            }
            else
            {
                var viewMain = new ViewMain();
                var controllerMain = new ControllerMain();
                var modelMain = new ModelMain(datenbank);

                viewMain.Controller = controllerMain;
                controllerMain.ModelMain = modelMain;
                modelMain.ViewMain = viewMain;

                Application.Run(viewMain);
            }
        }
    }
}