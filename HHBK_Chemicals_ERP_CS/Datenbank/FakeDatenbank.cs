using System;
using System.Collections.Generic;
using System.Linq;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Lager;
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
        ///     Eine "Tabelle" für Bestellpositionen
        /// </summary>
        private readonly Dictionary<int, Bestellposition> _bestellpositionen;

        /// <summary>
        ///     Eine "Tabelle" für Kunden
        /// </summary>
        private readonly Dictionary<int, Kunde> _kunden;


        /// <summary>
        ///     Eine "Tabelle" für Lieferpositionen
        /// </summary>
        private readonly Dictionary<int, Lieferposition> _lieferpositionen;


        /// <summary>
        ///     Eine "Tabelle" für Produkte
        /// </summary>
        private readonly Dictionary<int, Produkt> _produkte;


        /// <summary>
        ///     Eine "Tabelle" für Rezepte
        /// </summary>
        private readonly Dictionary<int, Rezept> _rezepte;

        /// <summary>
        ///     Ein "auto increment" Variable, welche bei jeder Erstellung eines <see cref="Rezept" />e erhöht wird und
        ///     als eine einzigartige <see cref="Rezept.RezeptNummer" /> verwendet wird
        /// </summary>
        private int _bestellPositionenAutoIncrementCount;

        /// <summary>
        ///     Ein "auto increment" Variable, welche bei jeder Erstellung eines <see cref="Kunde" />ns erhöht wird und
        ///     als eine einzigartige <see cref="Kunde.Kundennummer" /> verwendet wird
        /// </summary>
        private int _kundenAutoIncrementCount;

        /// <summary>
        ///     Ein "auto increment" Variable, welche bei jeder Erstellung eines <see cref="Lieferposition" />en erhöht
        ///     wird und als eine einzigartige <see cref="Lieferposition.Id" /> verwendet wird
        /// </summary>
        private int _lieferPositionenAutoIncrementCount;

        /// <summary>
        ///     Ein "auto increment" Variable, welche bei jeder Erstellung eines <see cref="Produkt" />e erhöht wird und
        ///     als eine einzigartige <see cref="Produkt.Artikelnummer" /> verwendet wird
        /// </summary>
        private int _produkteAutoIncrementCount;

        /// <summary>
        ///     Ein "auto increment" Variable, welche bei jeder Erstellung eines <see cref="Rezept" />e erhöht wird und
        ///     als eine einzigartige <see cref="Rezept.RezeptNummer" /> verwendet wird
        /// </summary>
        private int _rezepteAutoIncrementCount;


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
                {3, new Produkt(3, "Budget Chemical", 10, "g", 9.99m)}
            };
            _produkteAutoIncrementCount = _produkte.Count;

            _rezepte = new Dictionary<int, Rezept>
            {
                {1, new Rezept(1, 3, _produkte[1])},
                {2, new Rezept(2, 4, _produkte[1])},
                {3, new Rezept(3, 5, _produkte[2])}
            };
            _rezepteAutoIncrementCount = _rezepte.Count;

            _lieferpositionen = new Dictionary<int, Lieferposition>
            {
                {
                    1,
                    new Lieferposition(1, "123", DateTimeOffset.Now.AddDays(-1), DateTimeOffset.Now.AddHours(-1),
                        "Eine Kontrolle", "Eine Spedition")
                },
                {
                    2,
                    new Lieferposition(2, "456", DateTimeOffset.Now.AddDays(-4), DateTimeOffset.Now.AddHours(-4),
                        "Eine langsame Kontrolle", "Eine langsame Spedition")
                },
                {
                    3,
                    new Lieferposition(3, "789", DateTimeOffset.Now.AddDays(-1), DateTimeOffset.Now.AddHours(-16),
                        "Speedy-Kontrolle", "Speedy-tion")
                }
            };
            _lieferPositionenAutoIncrementCount = _lieferpositionen.Count;

            _bestellpositionen = new Dictionary<int, Bestellposition>
            {
                {
                    1,
                    new Bestellposition(1, _produkte[1], 123, 1, DateTimeOffset.Now.AddDays(-2), _kunden[1],
                        _lieferpositionen[1])
                },
                {
                    2,
                    new Bestellposition(2, _produkte[1], 456, 1, DateTimeOffset.Now.AddDays(-10), _kunden[3],
                        _lieferpositionen[2])
                },
                {
                    3,
                    new Bestellposition(3, _produkte[2], 789, 1, DateTimeOffset.Now.AddDays(-1), _kunden[1],
                        _lieferpositionen[3])
                }
            };
            _bestellPositionenAutoIncrementCount = _bestellpositionen.Count;
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


        public IEnumerable<Bestellposition> GetBestellungenVonKunde(Kunde kunde)
        {
            return GetBestellungenVonKunde(kunde.Kundennummer);
        }
        public IEnumerable<Bestellposition> GetBestellungenVonKunde(int kundennummer)
        {
            return _kunden.ContainsKey(kundennummer)
                ? _bestellpositionen.Values.Where(x => x.Kunde.Kundennummer == kundennummer)
                : null;
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

        #region Rezept

        public IEnumerable<Rezept> GetRezepte()
        {
            return _rezepte.Values;
        }

        public Rezept GetRezept(int artikelnummer)
        {
            return _rezepte.TryGetValue(artikelnummer, out var rezept) ? rezept : null;
        }

        public bool DeleteRezept(Rezept rezept)
        {
            return DeleteRezept(rezept.RezeptNummer);
        }

        public bool DeleteRezept(int artikelnummer)
        {
            return _rezepte.Remove(artikelnummer);
        }

        public Rezept CreateRezept()
        {
            var rezept = new Rezept(++_rezepteAutoIncrementCount, 0, null);
            AddOrUpdateRezept(rezept);
            return rezept;
        }

        public void UpdateRezept(Rezept rezept)
        {
            AddOrUpdateRezept(rezept);
        }


        private void AddOrUpdateRezept(Rezept rezept)
        {
            if (_rezepte.ContainsKey(rezept.RezeptNummer))
                _rezepte.Remove(rezept.RezeptNummer);

            _rezepte.Add(rezept.RezeptNummer, rezept);
        }

        #endregion

        #region Lieferposition

        public IEnumerable<Lieferposition> GetLieferpositionen()
        {
            return _lieferpositionen.Values;
        }

        public Lieferposition GetLieferposition(int artikelnummer)
        {
            return _lieferpositionen.TryGetValue(artikelnummer, out var lieferposition) ? lieferposition : null;
        }

        public bool DeleteLieferposition(Lieferposition lieferposition)
        {
            return DeleteLieferposition(lieferposition.Id);
        }

        public bool DeleteLieferposition(int artikelnummer)
        {
            return _lieferpositionen.Remove(artikelnummer);
        }

        public Lieferposition CreateLieferposition()
        {
            var lieferposition = new Lieferposition(++_lieferPositionenAutoIncrementCount, "", DateTimeOffset.Now, null,
                "", "");
            AddOrUpdateLieferposition(lieferposition);
            return lieferposition;
        }

        public void UpdateLieferposition(Lieferposition lieferposition)
        {
            AddOrUpdateLieferposition(lieferposition);
        }


        private void AddOrUpdateLieferposition(Lieferposition lieferposition)
        {
            if (_lieferpositionen.ContainsKey(lieferposition.Id))
                _lieferpositionen.Remove(lieferposition.Id);

            _lieferpositionen.Add(lieferposition.Id, lieferposition);
        }

        #endregion

        #region Bestellposition

        public IEnumerable<Bestellposition> GetBestellpositionen()
        {
            return _bestellpositionen.Values;
        }

        public Bestellposition GetBestellposition(int artikelnummer)
        {
            return _bestellpositionen.TryGetValue(artikelnummer, out var bestellposition) ? bestellposition : null;
        }

        public bool DeleteBestellposition(Bestellposition bestellposition)
        {
            return DeleteBestellposition(bestellposition.Bestellpositionsnummer);
        }

        public bool DeleteBestellposition(int artikelnummer)
        {
            return _bestellpositionen.Remove(artikelnummer);
        }

        public Bestellposition CreateBestellposition()
        {
            var bestellposition = new Bestellposition(++_bestellPositionenAutoIncrementCount, null, 0, 0,
                DateTimeOffset.Now, null, null);
            AddOrUpdateBestellposition(bestellposition);
            return bestellposition;
        }

        public Bestellposition CreateBestellposition(Kunde kunde)
        {
            var bestellposition = new Bestellposition(++_bestellPositionenAutoIncrementCount, null, 0, 0,
                DateTimeOffset.Now, kunde, null);
            AddOrUpdateBestellposition(bestellposition);
            return bestellposition;
        }

        public void UpdateBestellposition(Bestellposition bestellposition)
        {
            AddOrUpdateBestellposition(bestellposition);
        }


        private void AddOrUpdateBestellposition(Bestellposition bestellposition)
        {
            if (_bestellpositionen.ContainsKey(bestellposition.Bestellpositionsnummer))
                _bestellpositionen.Remove(bestellposition.Bestellpositionsnummer);

            _bestellpositionen.Add(bestellposition.Bestellpositionsnummer, bestellposition);
        }

        #endregion
    }
}