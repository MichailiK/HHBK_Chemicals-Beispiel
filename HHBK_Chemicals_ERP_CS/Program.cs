using System;
using System.Windows.Forms;
using HHBK_Chemicals_ERP_CS.Datenbank;
using HHBK_Chemicals_ERP_CS.Main;

namespace HHBK_Chemicals_ERP_CS
{
    internal static class Program
    {
        /// <summary>
        ///     Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var datenbank = new FakeDatenbank();

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