namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert ein Produkt
    /// </summary>
    public class Produkt
    {
        /// <summary>
        ///     Die einzigartige Artikelnummer des <see cref="Produkt" />s
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Artikelnummer;

        public Produkt(int artikelnummer, string name, int verkaufseinheit, string einheit, decimal preisVk)
        {
            Artikelnummer = artikelnummer;
            Name = name;
            Verkaufseinheit = verkaufseinheit;
            Einheit = einheit;
            PreisVk = preisVk;
        }

        public string Name { get; set; }

        // TODO "Verkaufsinheit" dokumentieren
        public int Verkaufseinheit { get; set; }

        // TODO "Einheit" dokumentieren
        public string Einheit { get; set; }

        /// <summary>
        ///     Der Verkaufspreis des <see cref="Produkt" />s
        /// </summary>
        public decimal PreisVk { get; set; }
    }
}