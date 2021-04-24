namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <summary>
    /// Repräsentiert eine Lagerposition 
    /// </summary>
    public class Lagerposition
    {
        /// <summary>
        /// Die einzigartige Identifikationsnummer des <see cref="Lagerposition"/>
        /// </summary>
        /// <remarks>Dies ist der Primärschlüssel auf der Datenbank</remarks>
        public int Lagerpositionsnummer { get; set; }
        
        public string Grundstoffname;
        public int Grundstoffmenge;
        
        // TODO "Grundstoffeinheit" dokumentieren
        public string Grundstoffeinheit;

        public Lagerposition(string grundstoffname, int grundstoffmenge, string grundstoffeinheit, int lagerpositionsnummer)
        {
            Grundstoffname = grundstoffname;
            Grundstoffmenge = grundstoffmenge;
            Grundstoffeinheit = grundstoffeinheit;
            Lagerpositionsnummer = lagerpositionsnummer;
        }
    }
}