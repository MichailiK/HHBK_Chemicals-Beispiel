namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <summary>
    ///     Repräsentiert eine Lagerposition
    /// </summary>
    public class Lagerposition
    {
        // TODO "Grundstoffeinheit" dokumentieren
        public string Grundstoffeinheit;
        public int Grundstoffmenge;

        public string Grundstoffname;

        public Lagerposition(string grundstoffname, int grundstoffmenge, string grundstoffeinheit,
            int lagerpositionsnummer)
        {
            Grundstoffname = grundstoffname;
            Grundstoffmenge = grundstoffmenge;
            Grundstoffeinheit = grundstoffeinheit;
            Lagerpositionsnummer = lagerpositionsnummer;
        }

        /// <summary>
        ///     Die einzigartige Identifikationsnummer des <see cref="Lagerposition" />
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public int Lagerpositionsnummer { get; set; }
    }
}