using System;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Lager;

namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert einen Produktionsplan für ein <see cref="Produkt" />
    /// </summary>
    /// <seealso cref="Produkt" />
    public class Produktionsplan
    {
        /// <summary>
        ///     Die einzigartige Identifikationsnummer des <see cref="Produktionsplan" />s
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Produktionsplannummer;

        [Obsolete(
            "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann keine Produktposition, Bestellposition & Kunde angegeben werden. Benutze stattdessen den anderen Konstruktor",
            true)]
        public Produktionsplan(int produktionsplannummer,
            DateTimeOffset startSoll,
            DateTimeOffset startIst,
            Rezept rezept,
            Produktionsposition produktionsposition,
            Bestellposition bestellposition,
            Kunde kunde)
        {
            Produktionsplannummer = produktionsplannummer;
            StartSoll = startSoll;
            StartIst = startIst;
            Rezept = rezept;
            Produktionsposition = produktionsposition;
            Bestellposition = bestellposition;
            Kunde = kunde;
        }

        public Produktionsplan(int produktionsplannummer,
            DateTimeOffset startSoll,
            DateTimeOffset startIst,
            Rezept rezept)
        {
            Produktionsplannummer = produktionsplannummer;
            StartSoll = startSoll;
            StartIst = startIst;
            Rezept = rezept;
        }

        public DateTimeOffset StartSoll { get; set; }
        public DateTimeOffset StartIst { get; set; }

        /// <summary>
        ///     Die <see cref="Produktion.Rezept" /> des <see cref="Produktionsplan" />
        /// </summary>
        /// <remarks>Dies ist ein Fremdschlüssel, "Rezept_Rezeptnummer", auf der Datenbank</remarks>
        /// <seealso cref="Produktion.Rezept" />
        public Rezept Rezept { get; set; }

        /// <summary>
        ///     Die <see cref="Produktion.Produktionsposition" /> des <see cref="Produktionsplan" />
        /// </summary>
        /// <remarks>
        ///     Dies ist ein Fremdschlüssel, "Produktionsposition_Produktionspositionsnummer", auf der Datenbank
        /// </remarks>
        /// <seealso cref="Produktion.Produktionsposition" />
        [Obsolete(
            "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann keine Produktposition, Bestellposition & Kunde angegeben werden.")]
        public Produktionsposition Produktionsposition
        {
            get => throw new NotSupportedException(
                "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann keine Produktionsposition angegeben werden.");
            set => throw new NotSupportedException(
                "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann keine Produktionsposition angegeben werden.");
        }

        /// <summary>
        ///     Die <see cref="Lager.Bestellposition" /> des <see cref="Produktionsplan" />
        /// </summary>
        /// <remarks>
        ///     Dies ist ein Fremdschlüssel, "Produktionsposition_Bestellposition_Bestellpositionsnummer", auf der
        ///     Datenbank
        /// </remarks>
        /// <seealso cref="Lager.Bestellposition" />
        [Obsolete(
            "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann keine Produktposition, Bestellposition & Kunde angegeben werden.")]
        public Bestellposition Bestellposition
        {
            get => throw new NotSupportedException(
                "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann keine Bestellposition angegeben werden.");
            set => throw new NotSupportedException(
                "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann keine Bestellposition angegeben werden.");
        }

        /// <summary>
        ///     Die <see cref="Kunden.Kunde" /> des <see cref="Produktionsplan" />
        /// </summary>
        /// <remarks>
        ///     Dies ist ein Fremdschlüssel, "Produktionsposition_Bestellposition_Kunde_Kundenummer", auf der Datenbank
        /// </remarks>
        /// <seealso cref="Lager.Bestellposition" />
        [Obsolete(
            "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann keine Produktposition, Bestellposition & Kunde angegeben werden.")]
        public Kunde Kunde
        {
            get => throw new NotSupportedException(
                "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann kein Kunde angegeben werden.");
            set => throw new NotSupportedException(
                "Aufgrund der 1:1 Beziehung zwischen Produktionsplan und Rezept, kann kein Kunde angegeben werden.");
        }
    }
}