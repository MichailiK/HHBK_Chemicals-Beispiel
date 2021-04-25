using System;

namespace HHBK_Chemicals_ERP_CS.Lager.Lieferposition
{
    /// <summary>
    ///     Repräsentiert eine Lieferung
    /// </summary>
    public class Lieferposition
    {
        /// <summary>
        ///     Die einzigartige Identifikationsnummer des <see cref="Lieferposition" />
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Id;

        public Lieferposition(int id, string liefernummer, DateTimeOffset versanddatum, DateTimeOffset? lieferdatum,
            string nameVersandkontrolle, string nameSpedition)
        {
            Id = id;
            Liefernummer = liefernummer;
            Versanddatum = versanddatum;
            Lieferdatum = lieferdatum;
            NameVersandkontrolle = nameVersandkontrolle;
            NameSpedition = nameSpedition;
        }

        public string Liefernummer { get; set; }
        public DateTimeOffset Versanddatum { get; set; }

        /// <summary>
        ///     Der <see cref="DateTimeOffset" /> von das Lieferdatum für die Lieferung
        /// </summary>
        /// <value>Ein <see cref="DateTimeOffset" />, welches <c>null</c> sein kann</value>
        public DateTimeOffset? Lieferdatum { get; set; }

        public string NameVersandkontrolle { get; set; }
        public string NameSpedition { get; set; }
    }
}