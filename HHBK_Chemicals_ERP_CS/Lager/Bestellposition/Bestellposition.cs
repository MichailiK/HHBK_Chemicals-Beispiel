using System;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <summary>
    ///     Repräsentiert eine Bestellung
    /// </summary>
    public class Bestellposition
    {
        /// <summary>
        ///     Die einzigartige Identifikationsnummer der <see cref="Bestellposition" />
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Bestellpositionsnummer;

        public Bestellposition(int bestellpositionsnummer,
            Produkt produkt,
            int bestellungsnummer,
            int menge,
            DateTimeOffset bestelldatum,
            Kunde kunde,
            Lieferposition lieferposition)
        {
            Bestellpositionsnummer = bestellpositionsnummer;
            Produkt = produkt;
            Bestellungsnummer = bestellungsnummer;
            Menge = menge;
            Bestelldatum = bestelldatum;
            Kunde = kunde;
            Lieferposition = lieferposition;
        }

        /// <summary>
        ///     Das <see cref="Produktion.Produkt" /> der <see cref="Bestellposition" />
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Produkt_Artikelnummer1", auf der Datenbank</remarks>
        /// <seealso cref="Produktion.Produkt" />
        public Produkt Produkt { get; set; }

        // TODO Bestellungsnummer dokumentieren
        public int Bestellungsnummer { get; set; }

        public int Menge { get; set; }
        public DateTimeOffset Bestelldatum { get; set; }

        /// <summary>
        ///     Der <see cref="Kunden.Kunde" /> der <see cref="Bestellposition" />
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Kunde_Kundennummer", auf der Datenbank</remarks>
        /// <seealso cref="Kunden.Kunde" />
        public Kunde Kunde { get; set; }

        /// <summary>
        ///     Der <see cref="HHBK_Chemicals_ERP_CS.Lieferung.Lieferposition" /> der <see cref="Bestellposition" />.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Lieferposition_idLieferposition", auf der Datenbank</remarks>
        /// <seealso cref="HHBK_Chemicals_ERP_CS.Lieferung.Lieferposition" />
        public Lieferposition Lieferposition { get; set; }
    }
}