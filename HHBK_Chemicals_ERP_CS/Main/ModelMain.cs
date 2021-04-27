using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HHBK_Chemicals_ERP_CS.Datenbank;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Main
{
    /// <inheritdoc cref="IModelMain" />
    public class ModelMain : IModelMain
    {
        private const int MaxPreviewEntries = 250;

        private readonly IDatenbank _datenbank;

        private List<Kunde> _kundenListe;
        private List<Produkt> _produktListe;

        public ModelMain(IDatenbank datenbank)
        {
            _datenbank = datenbank;
        }

        public IViewMain ViewMain { private get; set; }

        #region Kunde

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
            _kundenListe = _datenbank.GetKunden().Take(MaxPreviewEntries).ToList();
            ViewMain.KundenListeAktualisieren(
                _kundenListe.Select(
                    kunde => kunde.Kundennummer + ": " +
                             (string.IsNullOrWhiteSpace(kunde.Vorname) && string.IsNullOrWhiteSpace(kunde.Name)
                                 ? "<kein name>"
                                 : kunde.Vorname + " " + kunde.Name)));
        }

        #endregion

        #region Produkt

        public void GeklicktenProduktAnsehen(int index)
        {
            ProduktAnsehen(_produktListe[index]);
        }

        public void ProduktMitNummerÖffnen(int nummer)
        {
            var produkt = _datenbank.GetProdukt(nummer);
            if (produkt == null)
                MessageBox.Show("Das Produkt konnte nicht gefunden werden", "Produkt nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                ProduktAnsehen(produkt);
        }

        public void NeuenProduktErstellen()
        {
            ProduktAnsehen(_datenbank.CreateProdukt(""));
        }


        public void ProduktAnsehen(Produkt produkt)
        {
            var viewProdukt = new ViewProdukt();
            var modelProdukt = new ModelProdukt(_datenbank, produkt);
            var controllerProdukt = new ControllerProdukt(modelProdukt);

            viewProdukt.Controller = controllerProdukt;
            controllerProdukt.ModelProdukt = modelProdukt;
            modelProdukt.ViewProdukt = viewProdukt;

            viewProdukt.ShowDialog();

            ProduktListeAktualisieren();
        }

        public void ProduktListeAktualisieren()
        {
            _produktListe = _datenbank.GetProdukte().Take(MaxPreviewEntries).ToList();
            ViewMain.ProduktListeAktualisieren(
                _produktListe.Select(
                    produkt => produkt.Artikelnummer + ": " +
                               (string.IsNullOrWhiteSpace(produkt.Name) ? "<kein name>" : produkt.Name)
                               + " (" + produkt.Verkaufseinheit + produkt.Einheit + ", " + produkt.PreisVk + " €)"));
        }

        #endregion
    }
}