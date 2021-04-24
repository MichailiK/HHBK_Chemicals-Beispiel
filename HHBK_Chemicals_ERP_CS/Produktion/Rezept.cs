namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert ein Rezept
    /// </summary>
    public class Rezept
    {
        /// <summary>
        ///     Die einzigartige Rezeptnummer des <see cref="Rezept" />s
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public readonly int Rezeptnummer;

        /// <summary>
        ///     Die Herstellungsdauer in Minuten
        /// </summary>
        public int HerstellungsdauerMin;

        /// <summary>
        ///     Das <see cref="Produktion.Produkt" /> des <see cref="Rezept" />s
        /// </summary>
        public Produkt Produkt;

        public Rezept(int rezeptnummer, int herstellungsdauerMin, Produkt produkt)
        {
            Rezeptnummer = rezeptnummer;
            HerstellungsdauerMin = herstellungsdauerMin;
            Produkt = produkt;
        }
    }
}