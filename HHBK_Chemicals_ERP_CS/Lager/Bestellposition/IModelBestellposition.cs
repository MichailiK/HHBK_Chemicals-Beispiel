using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <summary>
    ///     Repräsentiert das Model für die <see cref="IViewBestellposition" />
    /// </summary>
    /// <seealso cref="Bestellposition" />
    /// <seealso cref="IViewBestellposition" />
    /// <seealso cref="IControllerBestellposition" />
    public interface IModelBestellposition
    {
        IViewBestellposition ViewBestellposition { set; }

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
        ///     Aktualisiert die <see cref="Bestellposition" /> mit den neuen Daten, die in der
        ///     <see cref="IViewBestellposition" /> angegeben sind
        /// </summary>
        void BestellpositionAktualisieren();

        /// <summary>
        ///     Löscht die <see cref="Bestellposition" /> aus der <see cref="Datenbank.IDatenbank" />
        /// </summary>
        void BestellpositionLöschen();

        /// <summary>
        ///     Setzt die Daten, die in der <see cref="IViewBestellposition" /> angegeben sind, zurück zu den Daten, die
        ///     zurzeit in der <see cref="Datenbank.IDatenbank" /> sind
        /// </summary>
        void BestellpositionZurücksetzen();
    }
}