using HHBK_Chemicals_ERP_CS.Lager;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Zahlung
{
    public class Rechnungsposition
    {
        /// <summary>
        /// Die einzigartige Artikelnummer des <see cref="Produkt"/>s
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Rechnungspositionsnummer;
        
        // TODO "Rechnungsnummer" dokumentieren
        public int Rechnungsnummer { get; set; }
        
        /// <summary>
        /// Die <see cref="Lager.Bestellposition"/> der <see cref="Rechnungsposition"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Bestellposition_Bestellpositionsnummer", auf der Datenbank</remarks>
        /// <seealso cref="Lager.Bestellposition"/>
        public Bestellposition Bestellposition { get; set; }
        
        /// <summary>
        /// Die <see cref="Produktion.Produkt"/> der <see cref="Rechnungsposition"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Bestellposition_Produkt_Artikelnummer1", auf der Datenbank</remarks>
        /// <seealso cref="Produktion.Produkt"/>
        public Produkt Produkt { get; set; }
        
        /// <summary>
        /// Die <see cref="HHBK_Chemicals_ERP_CS.Kunde.Kunde"/> der <see cref="Rechnungsposition"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Bestellposition_Kunde_Kundennummer", auf der Datenbank</remarks>
        /// <seealso cref="HHBK_Chemicals_ERP_CS.Kunde.Kunde"/>
        public Kunde.Kunde Kunde { get; set; }

        public Rechnungsposition(int rechnungspositionsnummer, int rechnungsnummer, Bestellposition bestellposition, Produkt produkt, Kunde.Kunde kunde)
        {
            Rechnungspositionsnummer = rechnungspositionsnummer;
            Rechnungsnummer = rechnungsnummer;
            Bestellposition = bestellposition;
            Produkt = produkt;
            Kunde = kunde;
        }
    }
}