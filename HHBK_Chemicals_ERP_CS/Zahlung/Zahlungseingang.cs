using System;
using HHBK_Chemicals_ERP_CS.Kunden;

namespace HHBK_Chemicals_ERP_CS.Zahlung
{
    /// <summary>
    ///     Repräsentiert eine Zahlung
    /// </summary>
    public class Zahlungseingang
    {
        /// <summary>
        ///     Die einzigartige Identifikationsnummer des <see cref="Zahlungseingang" />
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Zahlungseingangsnummer;


        public Zahlungseingang(int zahlungseingangsnummer,
            string verwendungszweckKdNr,
            string verweundungszweckeBestNr,
            DateTimeOffset datum,
            string nameKontoinhaber,
            string iban,
            Kunde kunde)
        {
            Zahlungseingangsnummer = zahlungseingangsnummer;
            VerwendungszweckKdNr = verwendungszweckKdNr;
            VerweundungszweckeBestNr = verweundungszweckeBestNr;
            Datum = datum;
            NameKontoinhaber = nameKontoinhaber;
            Iban = iban;
            Kunde = kunde;
        }

        public string VerwendungszweckKdNr { get; }
        public string VerweundungszweckeBestNr { get; }
        public DateTimeOffset Datum { get; }
        public string NameKontoinhaber { get; }
        public string Iban { get; }

        /// <summary>
        ///     Der <see cref="Kunden.Kunde" /> des <see cref="Zahlungseingang" />.
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Kunde_Kundennummer", auf der Datenbank</remarks>
        /// <seealso cref="Kunden.Kunde" />
        public Kunde Kunde { get; }
    }
}