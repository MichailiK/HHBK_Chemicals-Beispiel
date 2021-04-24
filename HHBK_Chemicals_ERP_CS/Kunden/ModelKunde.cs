using HHBK_Chemicals_ERP_CS.Datenbank;

namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <inheritdoc cref="IModelKunde" />
    public class ModelKunde : IModelKunde
    {
        private readonly IDatenbank _datenbank;
        private readonly Kunde _kunde;

        public ModelKunde(IDatenbank datenbank, Kunde kunde)
        {
            _datenbank = datenbank;
            _kunde = kunde;
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

            _datenbank.UpdateKunde(_kunde);
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
    }
}