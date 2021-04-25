using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HHBK_Chemicals_ERP_CS.Datenbank;
using HHBK_Chemicals_ERP_CS.Kunden;

namespace HHBK_Chemicals_ERP_CS.Main
{
    /// <inheritdoc cref="IModelMain"/>
    public class ModelMain : IModelMain
    {
        private readonly IDatenbank _datenbank;

        private List<Kunde> _kundenListe;


        public ModelMain(IDatenbank datenbank)
        {
            _datenbank = datenbank;
        }

        public IViewMain ViewMain { private get; set; }

        public void GeklicktenKundeAnsehen(int index)
        {
            KundeAnsehen(_kundenListe[index]);
        }

        public void KundeMitNummerÖffnen(int nummer)
        {
            var kunde = _datenbank.GetKunde(nummer);
            if (kunde == null)
                MessageBox.Show("Der Kunde konnte nicht gefunden werden", "Kunde nicht gefunden", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                KundeAnsehen(kunde);
        }

        public void NeuenKundeErstellen()
        {
            KundeAnsehen(_datenbank.CreateKunde("", ""));
        }


        public void KundeAnsehen(Kunde kunde)
        {
            var viewKunde = new ViewKunde();
            var modelKunde = new ModelKunde(_datenbank, kunde);
            var controllerKunde = new ControllerKunde(modelKunde);

            viewKunde.Controller = controllerKunde;
            controllerKunde.ModelKunde = modelKunde;
            modelKunde.ViewKunde = viewKunde;

            viewKunde.ShowDialog();

            KundenListeAktualisieren();
        }

        public void KundenListeAktualisieren()
        {
            _kundenListe = _datenbank.GetKunden().Take(250).ToList();
            ViewMain.KundenListeAktualisieren(
                _kundenListe.Select(
                    kunde => kunde.Kundennummer + ": " +
                             (string.IsNullOrWhiteSpace(kunde.Vorname) && string.IsNullOrWhiteSpace(kunde.Name)
                                 ? "<kein name>"
                                 : kunde.Vorname + " " + kunde.Name)));
        }
    }
}