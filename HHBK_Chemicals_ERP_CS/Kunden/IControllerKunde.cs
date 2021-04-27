using HHBK_Chemicals_ERP_CS.Lager;

namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <summary>
    ///     Repräsentiert den Controller für <see cref="IModelKunde" />
    /// </summary>
    /// <seealso cref="Kunde" />
    /// <seealso cref="IModelKunde" />
    /// <seealso cref="IViewKunde" />
    public interface IControllerKunde
    {
        IModelKunde ModelKunde { set; }

        /// <summary>
        ///     Aktualisiert den Kunden mit den neuen Daten, die im Form angegeben sind
        /// </summary>
        void KundeAktualisieren();

        /// <summary>
        ///     Löscht den Kunden aus der Datenbank
        /// </summary>
        void KundeLöschen();

        /// <summary>
        ///     Wird aufgerufen, wenn das Form sich geladen hat
        /// </summary>
        void FormGeladen();

        #region Bestellung

        /// <summary>
        ///     Wird aufgerufen, wenn auf eine Bestellung in der Bestellungsliste doppelgeklickt wird oder Enter gedrückt
        ///     wird
        /// </summary>
        /// <param name="index">Der ausgewählte index auf der Bestellungsliste</param>
        void BestellungGeklickt(int index);

        /// <summary>
        ///     Wird aufgerufen, wenn ein Bestellpositionsnummer angegeben worden ist, die eingesehen werden soll
        /// </summary>
        /// <param name="nummer">Die <see cref="Bestellposition.Bestellpositionsnummer" /></param>
        void BestellungMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Wird aufgerufen, wenn eine neue <see cref="Bestellposition" /> erstellt werden soll & der neu erstellte
        ///     Bestellung eingesehen werden soll
        /// </summary>
        void NeueBestellungErstellen();

        #endregion
    }
}