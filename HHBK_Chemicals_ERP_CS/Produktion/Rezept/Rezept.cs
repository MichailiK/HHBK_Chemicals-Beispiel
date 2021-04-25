namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert ein Rezept
    /// </summary>
    public class Rezept
    {
        /// <summary>
        ///     Die einzigartige Rezept Nummer des <see cref="Rezept" />s
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int RezeptNummer;

        /// <summary>
        ///     Die Herstellungsdauer in Minuten
        /// </summary>
        public int HerstellungsdauerMin;

        /// <summary>
        ///     Das <see cref="Produkt" /> des <see cref="Rezept" />s
        /// </summary>
        /// <remarks>Dies kann <c>null</c> sein</remarks>
        public Produkt Produkt;

        public Rezept(int rezeptNummer, int herstellungsdauerMin, Produkt produkt)
        {
            RezeptNummer = rezeptNummer;
            HerstellungsdauerMin = herstellungsdauerMin;
            Produkt = produkt;
        }
    }
}