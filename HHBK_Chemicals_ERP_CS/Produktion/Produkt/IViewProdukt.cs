namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert die View für das einlesen oder modifizieren für <see cref="Produkt" />en
    /// </summary>
    /// <seealso cref="Produkt" />
    /// <seealso cref="IModelProdukt"/>
    /// <seealso cref="IControllerProdukt"/>
    public interface IViewProdukt
    {
        IControllerProdukt Controller { set; }

        int Artikelnummer { get; set; }
        string ProduktName { get; set; }
        int Verkaufseinheit { get; set; }
        string Einheit { get; set; }
        decimal PreisVk { get; set; }
    }
}