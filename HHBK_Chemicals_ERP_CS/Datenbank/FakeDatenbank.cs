using System.Collections.Generic;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Datenbank
{
    /// <summary>
    ///     Eine einfache, unechte Datenbank zum experimentieren mit der Anwendung
    /// </summary>
    /// <seealso cref="IDatenbank" />
    public class FakeDatenbank : IDatenbank
    {
        /// <summary>
        ///     Eine "Tabelle" für Kunden
        /// </summary>
        private readonly Dictionary<int, Kunde> _kunden;

        /// <summary>
        ///     Ein "auto increment" Variable, welche bei jeder Erstellung eines <see cref="Kunde" />ns erhöht wird und
        ///     als eine einzigartige <see cref="Kunde.Kundennummer" /> verwendet wird
        /// </summary>
        private int _kundenAutoIncrementCount;

        
        /// <summary>
        ///     Eine "Tabelle" für Produkte
        /// </summary>
        private readonly Dictionary<int, Produkt> _produkte;

        /// <summary>
        ///     Ein "auto increment" Variable, welche bei jeder Erstellung eines <see cref="Produkt" />e erhöht wird und
        ///     als eine einzigartige <see cref="Produkt.Artikelnummer" /> verwendet wird
        /// </summary>
        private int _produkteAutoIncrementCount;



        /// <summary>
        ///     Initialisiert eine Datenbank mit 3 Beispieleinträgen
        /// </summary>
        public FakeDatenbank()
        {
            _kunden = new Dictionary<int, Kunde>
            {
                {1, new Kunde(1, "K", "Michail", "Eine straße", 69, 1337, "Düsseldorf", "eine@email.com")},
                {2, new Kunde(2, "Han irgendwas", "Fatih", "Yarrakstr.", 2, 6969, "Irgendwo", "fatih@gmail.com")},
                {3, new Kunde(3, "der Zweite", "Michail", "eine str.", 10, 1234, "ein ort", "noch.eine@email.com")}
            };
            _kundenAutoIncrementCount = _kunden.Count;

            _produkte = new Dictionary<int, Produkt>
            {
                {1, new Produkt(1, "Ein Produkt! Wow!", 20, "g", 19.99m)},
                {2, new Produkt(2, "So ein Chemical", 50, "g", 49.99m)},
                {3, new Produkt(2, "Budget Chemical", 10, "g", 9.99m)}
            };
            _produkteAutoIncrementCount = _produkte.Count;
        }

        #region Kunde

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
            var kunde = new Kunde(++_kundenAutoIncrementCount, name, vorname, "", 0, 0, "", "");
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

        #endregion

        #region Produkt

        public IEnumerable<Produkt> GetProdukte()
        {
            return _produkte.Values;
        }

        public Produkt GetProdukt(int artikelnummer)
        {
            return _produkte.TryGetValue(artikelnummer, out var produkt) ? produkt : null;
        }

        public bool DeleteProdukt(Produkt produkt)
        {
            return DeleteProdukt(produkt.Artikelnummer);
        }

        public bool DeleteProdukt(int artikelnummer)
        {
            return _produkte.Remove(artikelnummer);
        }

        public Produkt CreateProdukt(string produktname)
        {
            var produkt = new Produkt(++_produkteAutoIncrementCount, produktname, 0, "", 0m);
            AddOrUpdateProdukt(produkt);
            return produkt;
        }

        public void UpdateProdukt(Produkt produkt)
        {
            AddOrUpdateProdukt(produkt);
        }


        private void AddOrUpdateProdukt(Produkt produkt)
        {
            if (_produkte.ContainsKey(produkt.Artikelnummer))
                _produkte.Remove(produkt.Artikelnummer);

            _produkte.Add(produkt.Artikelnummer, produkt);
        }
        
        #endregion
    }
}