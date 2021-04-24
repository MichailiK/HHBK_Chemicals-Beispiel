using System;
using HHBK_Chemicals_ERP_CS.Lager;

namespace HHBK_Chemicals_ERP_CS.Produktion
{
    public class Produktionsposition
    {
        /// <summary>
        /// Die einzigartige Identifikationsnummer des <see cref="Produktionsposition"/>s
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Produktionspositionsnummer;
        
        /// <summary>
        /// Das <see cref="Produktion.Produkt"/> der <see cref="Produktionsposition"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Produkt_Artikelnummer", auf der Datenbank</remarks>
        /// <seealso cref="Produktion.Produkt"/>
        public Produkt Produkt { get; set; }
        
        // TODO "DatumProduktionsfreigabe" dokumentieren
        public DateTimeOffset DatumProduktionsfreigabe { get; set; }
        
        public DateTimeOffset DatumProduktion { get; set; }
        
        // TODO "NameProduktionsfreigabe" dokumentieren
        public string NameProduktionsfreigabe { get; set; }
        
        public string NameProduzent { get; set; }
        
        /// <summary>
        /// Die <see cref="Lager.Bestellposition"/> der <see cref="Produktionsposition"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Bestellposition_Bestellpositionsnummer", auf der Datenbank</remarks>
        /// <seealso cref="Lager.Bestellposition"/>
        public Bestellposition Bestellposition { get; set; }
        
        /// <summary>
        /// Die <see cref="HHBK_Chemicals_ERP_CS.Kunde.Kunde"/> der <see cref="Produktionsposition"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Bestellposition_Kunde_Kundenummer", auf der Datenbank</remarks>
        /// <seealso cref="HHBK_Chemicals_ERP_CS.Kunde.Kunde"/>
        public Kunde.Kunde Kunde { get; set; }

        public Produktionsposition(int produktionspositionsnummer, Produkt produkt, DateTimeOffset datumProduktionsfreigabe, DateTimeOffset datumProduktion, string nameProduktionsfreigabe, string nameProduzent, Bestellposition bestellposition, Kunde.Kunde kunde)
        {
            Produktionspositionsnummer = produktionspositionsnummer;
            Produkt = produkt;
            DatumProduktionsfreigabe = datumProduktionsfreigabe;
            DatumProduktion = datumProduktion;
            NameProduktionsfreigabe = nameProduktionsfreigabe;
            NameProduzent = nameProduzent;
            Bestellposition = bestellposition;
            Kunde = kunde;
        }
    }
}