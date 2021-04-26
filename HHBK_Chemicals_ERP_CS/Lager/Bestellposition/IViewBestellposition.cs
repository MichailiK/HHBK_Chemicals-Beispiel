using System;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <summary>
    ///     Repräsentiert die View für das einlesen oder modifizieren für <see cref="Bestellposition" />en
    /// </summary>
    /// <seealso cref="Bestellposition" />
    /// <seealso cref="IModelBestellposition" />
    /// <seealso cref="IControllerBestellposition" />
    public interface IViewBestellposition
    {
        IControllerBestellposition Controller { set; }

        int Bestellpositionsnummer { get; set; }

        /// <summary>
        ///     Die <see cref="Produkt.Artikelnummer" />
        /// </summary>
        int ArtikelNummer { get; set; }

        int Bestellungsnummer { get; set; }
        int Menge { get; set; }
        DateTimeOffset Bestelldatum { get; set; }

        /// <summary>
        ///     Die <see cref="Kunde.Kundennummer" />
        /// </summary>
        int Kundennummer { get; set; }

        /// <summary>
        ///     Die <see cref="Lieferposition.Id" />
        /// </summary>
        int LieferpositionId { get; set; }
    }
}