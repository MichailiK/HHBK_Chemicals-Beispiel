using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HHBK_Chemicals_ERP_CS.Datenbank;
using HHBK_Chemicals_ERP_CS.Lager;

namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <inheritdoc cref="IModelKunde" />
    public class ModelKunde : IModelKunde
    {
        private const int MaxPreviewEntries = 50;

        private readonly IDatenbank _datenbank;
        private Kunde _kunde;
        private List<Bestellposition> _bestellungListe;

        public ModelKunde(IDatenbank datenbank, Kunde kunde)
        {
            _datenbank = datenbank;
            _kunde = kunde ?? new Kunde();
        }

        public IViewKunde ViewKunde { private get; set; }

        public void KundeAktualisieren()
        {
            _kunde.Name = ViewKunde.Nachname;
            _kunde.Vorname = ViewKunde.Vorname;
            _kunde.Strasse = ViewKunde.Strasse;
            _kunde.Hausnummer = ViewKunde.Hausnummer;
            _kunde.Postleitzahl = ViewKunde.Postleitzahl;
            _kunde.Ort = ViewKunde.Ort;
            _kunde.EmailAdresse = ViewKunde.EmailAdresse;

            _kunde = _datenbank.CreateOrUpdateKunde(_kunde);
        }

        public void KundeZurücksetzen()
        {
            ViewKunde.Kundennummer = _kunde.Kundennummer;
            ViewKunde.Nachname = _kunde.Name;
            ViewKunde.Vorname = _kunde.Vorname;
            ViewKunde.Strasse = _kunde.Strasse;
            ViewKunde.Hausnummer = _kunde.Hausnummer;
            ViewKunde.Postleitzahl = _kunde.Postleitzahl;
            ViewKunde.Ort = _kunde.Ort;
            ViewKunde.EmailAdresse = _kunde.EmailAdresse;
        }

        public void KundeLöschen()
        {
            _datenbank.DeleteKunde(_kunde);
        }

        #region Bestellung

        public void GeklickteBestellungAnsehen(int index)
        {
            if(_bestellungListe == null)
                throw new InvalidOperationException();
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
            BestellungAnsehen(_datenbank.CreateBestellposition(_kunde));
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
            if (_kunde.Kundennummer == null)
                _bestellungListe = null;
            else
                _bestellungListe = _datenbank.GetBestellungenVonKunde(_kunde).Take(MaxPreviewEntries).ToList();
            ViewKunde.BestellungsListeAktualisieren(
                _bestellungListe?.Select(
                    bestellung => bestellung.Bestellpositionsnummer + ": " + bestellung.Bestellungsnummer));
        }

        #endregion
    }
}