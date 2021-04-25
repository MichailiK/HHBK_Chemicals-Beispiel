namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert die View für das einlesen oder modifizieren für <see cref="Rezept" />en
    /// </summary>
    /// <seealso cref="Rezept" />
    /// <seealso cref="IModelRezept"/>
    /// <seealso cref="IControllerRezept"/>
    public interface IViewRezept
    {
        IControllerRezept Controller { set; }
        
        int RezeptNummer { get; set; }
        int HerstellungsdauerMin { get; set; }
        int ArtikelNummer { get; set; }
    }
}