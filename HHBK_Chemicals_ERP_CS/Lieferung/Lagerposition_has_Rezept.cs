using HHBK_Chemicals_ERP_CS.Lager;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Lieferung
{
    /// <summary>
    /// Repräsentiert ein <see cref="Produktion.Rezept"/> mit einer <see cref="Lagerposition"/>
    /// </summary>
    public class Lagerposition_has_Rezept
    {
        public Lagerposition Lagerposition { get; set; }
        public Rezept Rezept { get; set; }
        public int Menge { get; set; }
        
        // TODO "Einheit" dokumentieren
        public string Einheit { get; set; }

        public Lagerposition_has_Rezept(Lagerposition lagerposition, Rezept rezept, int menge, string einheit)
        {
            Lagerposition = lagerposition;
            Rezept = rezept;
            Menge = menge;
            Einheit = einheit;
        }
    }
}