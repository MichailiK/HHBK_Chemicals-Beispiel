using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <summary>
    ///     Repräsentiert den Controller für <see cref="IModelBestellposition" />
    /// </summary>
    /// <seealso cref="Bestellposition" />
    /// <seealso cref="IModelBestellposition" />
    /// <seealso cref="IViewBestellposition" />
    public interface IControllerBestellposition
    {
        IModelBestellposition ModelBestellposition { set; }

        /// <summary>
        ///     Öffnet eine <see cref="IViewProdukt" /> mit der angegeben <see cref="Produkt.Artikelnummer" />
        /// </summary>
        /// <param name="artikelnummer">Die <see cref="Produkt.Artikelnummer" /></param>
        void ProduktÖffnen(int artikelnummer);

        /// <summary>
        ///     Öffnet eine <see cref="IViewKunde" /> mit der angegeben <see cref="Kunde.Kundennummer" />
        /// </summary>
        /// <param name="kundennummer">Die <see cref="Kunde.Kundennummer" /></param>
        void KundeÖffnen(int kundennummer);

        /// <summary>
        ///     Öffnet eine <see cref="IViewLieferposition" /> mit der angegeben <see cref="Lieferposition.Id" />
        /// </summary>
        /// <param name="lieferpositionId">Die <see cref="Lieferposition.Id" /></param>
        void LieferpositionÖffnen(int lieferpositionId);

        /// <summary>
        ///     Aktualisiert die Bestellposition mit den neuen Daten, die im Form angegeben sind
        /// </summary>
        void BestellpositionAktualisieren();

        /// <summary>
        ///     Löscht die Bestellposition aus der Datenbank
        /// </summary>
        void BestellpositionLöschen();

        /// <summary>
        ///     Wird aufgerufen, wenn das Form sich geladen hat
        /// </summary>
        void FormGeladen();
    }
}