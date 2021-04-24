using System;

namespace HHBK_Chemicals_ERP_CS.Zahlung
{
    /// <summary>
    /// Repräsentiert eine Zahlung
    /// </summary>
    public class Zahlungseingang
    {
        /// <summary>
        /// Die einzigartige Identifikationsnummer des <see cref="Zahlungseingang"/>
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Zahlungseingangsnummer;
        
        public string VerwendungszweckKdNr { get; private set; }
        public string VerweundungszweckeBestNr { get; private set; }
        public DateTimeOffset Datum { get; private set; }
        public string NameKontoinhaber { get; private set; }
        public string IBAN { get; private set; }
        
        /// <summary>
        /// Der <see cref="HHBK_Chemicals_ERP_CS.Kunde.Kunde"/> des <see cref="Zahlungseingang"/>.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Kunde_Kundennummer", auf der Datenbank</remarks>
        /// <seealso cref="HHBK_Chemicals_ERP_CS.Kunde.Kunde"/>
        public Kunde.Kunde Kunde { get; private set; }


        public Zahlungseingang(int zahlungseingangsnummer,
            string verwendungszweckKdNr,
            string verweundungszweckeBestNr,
            DateTimeOffset datum,
            string nameKontoinhaber,
            string iban,
            Kunde.Kunde kunde)
        {
            Zahlungseingangsnummer = zahlungseingangsnummer;
            VerwendungszweckKdNr = verwendungszweckKdNr;
            VerweundungszweckeBestNr = verweundungszweckeBestNr;
            Datum = datum;
            NameKontoinhaber = nameKontoinhaber;
            IBAN = iban;
            Kunde = kunde;
        }
    }
}