namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <summary>
    ///     Repräsentiert ein Kunde
    /// </summary>
    /// <seealso cref="IViewKunde"/>
    public class Kunde
    {
        /// <summary>
        ///     Die einzigartige Identifikationsnummer des <see cref="Kunde" />
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Kundennummer;


        public Kunde(int kundennummer,
            string name,
            string vorname,
            string strasse,
            int hausnummer,
            int postleitzahl,
            string ort,
            string emailAdresse)
        {
            Kundennummer = kundennummer;
            Name = name;
            Vorname = vorname;
            Strasse = strasse;
            Hausnummer = hausnummer;
            Postleitzahl = postleitzahl;
            Ort = ort;
            EmailAdresse = emailAdresse;
        }

        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Strasse { get; set; }
        public int Hausnummer { get; set; }
        public int Postleitzahl { get; set; }
        public string Ort { get; set; }
        public string EmailAdresse { get; set; }
    }
}