using System;

namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <summary>
    ///     Repräsentiert die View für das einlesen oder modifizieren für <see cref="Lieferposition" />en
    /// </summary>
    /// <seealso cref="Lieferposition" />
    /// <seealso cref="IModelLieferposition" />
    /// <seealso cref="IControllerLieferposition" />
    public interface IViewLieferposition
    {
        IControllerLieferposition Controller { set; }

        int Id { get; set; }
        string Liefernummer { get; set; }
        DateTimeOffset Versanddatum { get; set; }
        DateTimeOffset? Lieferdatum { get; set; }
        string NameVersandKontrolle { get; set; }
        string NameSpedition { get; set; }
    }
}