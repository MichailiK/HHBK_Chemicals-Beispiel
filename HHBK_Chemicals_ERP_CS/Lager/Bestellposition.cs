using System;
using HHBK_Chemicals_ERP_CS.Lieferung;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Lager
{
    public class Bestellposition
    {
        /// <summary>
        /// Die einzigartige Identifikationsnummer der <see cref="Bestellposition"/>
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Bestellpositionsnummer;
        
        // TODO Bestellungsnummer dokumentieren
        public int Bestellungsnummer { get; set; }
        
        public int Menge { get; set; }
        public DateTimeOffset Bestelldatum { get; set; }
        
        /// <summary>
        /// Das <see cref="Produktion.Produkt"/> der <see cref="Bestellposition"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Produkt_Artikelnummer1", auf der Datenbank</remarks>
        /// <seealso cref="Produktion.Produkt"/>
        public Produkt Produkt;

        /// <summary>
        /// Der <see cref="HHBK_Chemicals_ERP_CS.Kunde.Kunde"/> der <see cref="Bestellposition"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Kunde_Kundennummer", auf der Datenbank</remarks>
        /// <seealso cref="HHBK_Chemicals_ERP_CS.Kunde.Kunde"/>
        public Kunde.Kunde Kunde { get; set; }
        
        /// <summary>
        /// Der <see cref="HHBK_Chemicals_ERP_CS.Lieferung.Lieferposition"/> der <see cref="Bestellposition"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Lieferposition_idLieferposition", auf der Datenbank</remarks>
        /// <seealso cref="HHBK_Chemicals_ERP_CS.Lieferung.Lieferposition"/>
        public Lieferposition Lieferposition { get; set; }

        public Bestellposition(int bestellpositionsnummer,
            Produkt produkt,
            int bestellungsnummer,
            int menge,
            DateTimeOffset bestelldatum,
            Kunde.Kunde kunde,
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
    }
}