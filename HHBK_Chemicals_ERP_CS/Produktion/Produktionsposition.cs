using System;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Lager;

namespace HHBK_Chemicals_ERP_CS.Produktion
{
    public class Produktionsposition
    {
        /// <summary>
        ///     Die einzigartige Identifikationsnummer des <see cref="Produktionsposition" />s
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Produktionspositionsnummer;

        [Obsolete(
            "Dieser Konstruktor setzt Felder, welche zu Daten-Anomalien führen kann. Benutze stattdessen den anderen Konstruktor")]
        public Produktionsposition(int produktionspositionsnummer, Produkt produkt,
            DateTimeOffset datumProduktionsfreigabe, DateTimeOffset datumProduktion, string nameProduktionsfreigabe,
            string nameProduzent, Bestellposition bestellposition, Kunde kunde)
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

        public Produktionsposition(int produktionspositionsnummer,
            DateTimeOffset datumProduktionsfreigabe, DateTimeOffset datumProduktion, string nameProduktionsfreigabe,
            string nameProduzent, Bestellposition bestellposition)
        {
            Produktionspositionsnummer = produktionspositionsnummer;
            DatumProduktionsfreigabe = datumProduktionsfreigabe;
            DatumProduktion = datumProduktion;
            NameProduktionsfreigabe = nameProduktionsfreigabe;
            NameProduzent = nameProduzent;
            Bestellposition = bestellposition;
        }

        /// <summary>
        ///     Das <see cref="Produktion.Produkt" /> der <see cref="Produktionsposition" />
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Produkt_Artikelnummer", auf der Datenbank</remarks>
        /// <seealso cref="Produktion.Produkt" />
        [Obsolete(
            "Dieses Feld zu benutzen kann zu Daten-Anomalien führen, benutzte Bestellposition.Produkt stattdessen")]
        public Produkt Produkt { get; set; }

        // TODO "DatumProduktionsfreigabe" dokumentieren
        public DateTimeOffset DatumProduktionsfreigabe { get; set; }

        public DateTimeOffset DatumProduktion { get; set; }

        // TODO "NameProduktionsfreigabe" dokumentieren
        public string NameProduktionsfreigabe { get; set; }

        public string NameProduzent { get; set; }

        /// <summary>
        ///     Die <see cref="Lager.Bestellposition" /> der <see cref="Produktionsposition" />
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Bestellposition_Bestellpositionsnummer", auf der Datenbank</remarks>
        /// <seealso cref="Lager.Bestellposition" />
        public Bestellposition Bestellposition { get; set; }

        /// <summary>
        ///     Die <see cref="Kunden.Kunde" /> der <see cref="Produktionsposition" />
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Bestellposition_Kunde_Kundenummer", auf der Datenbank</remarks>
        /// <seealso cref="Kunden.Kunde" />
        [Obsolete("Dieses Feld zu benutzen kann zu Daten-Anomalien führen, benutzte Bestellposition.Kunde stattdessen")]
        public Kunde Kunde { get; set; }
    }
}