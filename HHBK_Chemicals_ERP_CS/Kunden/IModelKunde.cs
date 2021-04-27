using HHBK_Chemicals_ERP_CS.Lager;

namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <summary>
    ///     Repräsentiert das Model für das <see cref="IViewKunde" />
    /// </summary>
    /// <seealso cref="Kunde" />
    /// <seealso cref="IViewKunde" />
    /// <seealso cref="IControllerKunde" />
    public interface IModelKunde
    {
        IViewKunde ViewKunde { set; }

        /// <summary>
        ///     Aktualisiert den <see cref="Kunde" /> mit den neuen Daten, die in der <see cref="IViewKunde" /> angegeben
        ///     sind
        /// </summary>
        void KundeAktualisieren();

        /// <summary>
        ///     Löscht den <see cref="Kunde" /> aus der <see cref="Datenbank.IDatenbank" />
        /// </summary>
        void KundeLöschen();

        /// <summary>
        ///     Setzt die Daten, die in der <see cref="IViewKunde" /> angegeben sind, zurück zu den Daten, die zurzeit
        ///     in der <see cref="Datenbank.IDatenbank" /> sind
        /// </summary>
        void KundeZurücksetzen();

        #region Bestellung

        /// <summary>
        ///     Öffnet eine <see cref="IViewBestellposition" /> mit den <see cref="Bestellposition" />, der auf die Liste geklickt
        ///     worden
        ///     ist
        /// </summary>
        /// <param name="index">Index des geklickten Element auf der Liste</param>
        void GeklickteBestellungAnsehen(int index);

        /// <summary>
        ///     Öffnet eine <see cref="IViewBestellposition" /> mit der angegebene
        ///     <see cref="Bestellposition.Bestellpositionsnummer" />
        /// </summary>
        /// <param name="nummer">Die <see cref="Bestellposition.Bestellpositionsnummer" /></param>
        void BestellungMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Erstellt eine neue <see cref="Bestellposition" /> in der Datenbank und öffnet eine
        ///     <see cref="IViewBestellposition" />
        /// </summary>
        void NeueBestellungErstellen();

        /// <summary>
        ///     Öffnet eine <see cref="IViewBestellposition" /> für den <paramref name="bestellposition" />
        /// </summary>
        /// <param name="bestellposition">
        ///     Die <see cref="Bestellposition" /> für den eine <see cref="IViewBestellposition" /> geöffnet werden soll
        /// </param>
        void BestellungAnsehen(Bestellposition bestellposition);

        /// <summary>
        ///     Aktualisiert die Bestellungliste auf der <see cref="IViewBestellposition" />
        /// </summary>
        void BestellungListeAktualisieren();

        #endregion
    }
}