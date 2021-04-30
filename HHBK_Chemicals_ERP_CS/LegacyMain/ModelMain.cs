using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HHBK_Chemicals_ERP_CS.Datenbank;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Lager;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.LegacyMain
{
    /// <inheritdoc cref="IModelMain" />
    public class ModelMain : IModelMain
    {
        private const int MaxPreviewEntries = 250;

        private readonly IDatenbank _datenbank;
        private List<Bestellposition> _bestellungListe;

        private List<Kunde> _kundenListe;
        private List<Lieferposition> _lieferungListe;
        private List<Produkt> _produktListe;
        private List<Rezept> _rezeptListe;

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
            KundeAnsehen(null);
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

        #region Rezept

        public void GeklicktenRezeptAnsehen(int index)
        {
            RezeptAnsehen(_rezeptListe[index]);
        }

        public void RezeptMitNummerÖffnen(int nummer)
        {
            var rezept = _datenbank.GetRezept(nummer);
            if (rezept == null)
                MessageBox.Show("Das Rezept konnte nicht gefunden werden", "Rezept nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                RezeptAnsehen(rezept);
        }

        public void NeuenRezeptErstellen()
        {
            RezeptAnsehen(_datenbank.CreateRezept());
        }


        public void RezeptAnsehen(Rezept rezept)
        {
            var viewRezept = new ViewRezept();
            var modelRezept = new ModelRezept(_datenbank, rezept);
            var controllerRezept = new ControllerRezept(modelRezept);

            viewRezept.Controller = controllerRezept;
            controllerRezept.ModelRezept = modelRezept;
            modelRezept.ViewRezept = viewRezept;

            viewRezept.ShowDialog();

            RezeptListeAktualisieren();
        }

        public void RezeptListeAktualisieren()
        {
            _rezeptListe = _datenbank.GetRezepte().Take(MaxPreviewEntries).ToList();
            ViewMain.RezeptListeAktualisieren(
                _rezeptListe.Select(
                    rezept => rezept.RezeptNummer + ": Rezept für " +
                              (rezept.Produkt == null
                                  ? "unbekanntes Artikel"
                                  : "Artikel " + rezept.Produkt.Artikelnummer)));
        }

        #endregion

        #region Lieferung

        public void GeklickteLieferungAnsehen(int index)
        {
            LieferungAnsehen(_lieferungListe[index]);
        }

        public void LieferungMitNummerÖffnen(int nummer)
        {
            var lieferung = _datenbank.GetLieferposition(nummer);
            if (lieferung == null)
                MessageBox.Show("Das Lieferung konnte nicht gefunden werden", "Lieferung nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                LieferungAnsehen(lieferung);
        }

        public void NeueLieferungErstellen()
        {
            LieferungAnsehen(_datenbank.CreateLieferposition());
        }


        public void LieferungAnsehen(Lieferposition lieferung)
        {
            var viewLieferung = new ViewLieferposition();
            var modelLieferung = new ModelLieferposition(_datenbank, lieferung);
            var controllerLieferung = new ControllerLieferposition(modelLieferung);

            viewLieferung.Controller = controllerLieferung;
            controllerLieferung.ModelLieferposition = modelLieferung;
            modelLieferung.ViewLieferposition = viewLieferung;

            viewLieferung.ShowDialog();

            LieferungListeAktualisieren();
        }

        public void LieferungListeAktualisieren()
        {
            _lieferungListe = _datenbank.GetLieferpositionen().Take(MaxPreviewEntries).ToList();
            ViewMain.LieferungListeAktualisieren(
                _lieferungListe.Select(
                    lieferung => lieferung.Id + ": " + lieferung.Liefernummer + " (" +
                                 lieferung.Versanddatum.ToString("dd.MM.yyyy") + ")"));
        }

        #endregion

        #region Bestellung

        public void GeklickteBestellungAnsehen(int index)
        {
            BestellungAnsehen(_bestellungListe[index]);
        }

        public void BestellungMitNummerÖffnen(int nummer)
        {
            var bestellung = _datenbank.GetBestellposition(nummer);
            if (bestellung == null)
                MessageBox.Show("Das Bestellung konnte nicht gefunden werden", "Bestellung nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                BestellungAnsehen(bestellung);
        }

        public void NeueBestellungErstellen()
        {
            BestellungAnsehen(_datenbank.CreateBestellposition());
        }

        public void BestellungAnsehen(Bestellposition bestellposition)
        {
            var viewBestellung = new ViewBestellposition();
            var modelBestellung = new ModelBestellposition(_datenbank, bestellposition);
            var controllerBestellung = new ControllerBestellposition(modelBestellung);

            viewBestellung.Controller = controllerBestellung;
            controllerBestellung.ModelBestellposition = modelBestellung;
            modelBestellung.ViewBestellposition = viewBestellung;

            viewBestellung.ShowDialog();

            BestellungListeAktualisieren();
        }

        public void BestellungListeAktualisieren()
        {
            _bestellungListe = _datenbank.GetBestellpositionen().Take(MaxPreviewEntries).ToList();
            ViewMain.BestellungListeAktualisieren(
                _bestellungListe.Select(
                    bestellung => bestellung.Bestellpositionsnummer + ": " + bestellung.Bestellungsnummer));
        }

        #endregion
    }
}