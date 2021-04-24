using System.Collections.Generic;
using HHBK_Chemicals_ERP_CS.Kunden;

namespace HHBK_Chemicals_ERP_CS.Datenbank
{
    /// <summary>
    ///     Eine einfache, unechte Datenbank für das experimentieren gedacht.
    /// </summary>
    /// <seealso cref="IDatenbank" />
    public class FakeDatenbank : IDatenbank
    {
        /// <summary>
        ///     Eine fake-Tabelle für Kunden
        /// </summary>
        private readonly Dictionary<int, Kunde> _kunden;

        /// <summary>
        ///     Ein auto increment variable, welche bei jeder erstellung eines
        ///     <see cref="Kunde" />ns erstellt wird und als eine einzigartige
        ///     <see cref="Kunde.Kundennummer" /> verwendet wird
        /// </summary>
        private int _autoIncrementCount;

        /// <summary>
        ///     Initialisiert eine Datenbank mit 3 Beispieleinträgen.
        /// </summary>
        public FakeDatenbank()
        {
            _kunden = new Dictionary<int, Kunde>
            {
                {1, new Kunde(1, "K", "Michail", "Eine straße", 69, 1337, "Düsseldorf", "eine@email.com")},
                {2, new Kunde(2, "Han irgendwas", "Fatih", "Yarrakstr.", 2, 6969, "Irgendwo", "fatih@gmail.com")},
                {3, new Kunde(3, "der Zweite", "Michail", "eine str.", 10, 1234, "ein ort", "noch.eine@email.com")}
            };

            _autoIncrementCount = _kunden.Count;
        }

        public IEnumerable<Kunde> GetKunden()
        {
            return _kunden.Values;
        }

        public Kunde GetKunde(int kundennummer)
        {
            return _kunden.TryGetValue(kundennummer, out var kunde) ? kunde : null;
        }

        public bool DeleteKunde(Kunde kunde)
        {
            return DeleteKunde(kunde.Kundennummer);
        }

        public bool DeleteKunde(int kundennummer)
        {
            return _kunden.Remove(kundennummer);
        }

        public Kunde CreateKunde(string name, string vorname)
        {
            var kunde = new Kunde(++_autoIncrementCount, name, vorname, "", 0, 0, "", "");
            AddOrUpdateKunde(kunde);
            return kunde;
        }

        public void UpdateKunde(Kunde kunde)
        {
            AddOrUpdateKunde(kunde);
        }


        private void AddOrUpdateKunde(Kunde kunde)
        {
            if (_kunden.ContainsKey(kunde.Kundennummer))
                _kunden.Remove(kunde.Kundennummer);

            _kunden.Add(kunde.Kundennummer, kunde);
        }
    }
}