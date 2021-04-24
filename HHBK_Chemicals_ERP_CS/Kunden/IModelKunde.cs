namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <summary>
    ///     Repräsentiert das Model für das <see cref="IViewKunde" />
    /// </summary>
    /// <seealso cref="Kunde"/>
    /// <seealso cref="IViewKunde" />
    /// <seealso cref="IControllerKunde"/>
    public interface IModelKunde
    {
        IViewKunde ViewKunde { set; }

        /// <summary>
        ///     Aktualisiert den <see cref="Kunde"/> mit den neuen Daten, die in der <see cref="IViewKunde"/> angegeben
        ///     sind.
        /// </summary>
        void KundeAktualisieren();

        /// <summary>
        ///     Löscht den <see cref="Datenbank.IDatenbank"/> aus der Datenbank
        /// </summary>
        void KundeLöschen();
        
        /// <summary>
        ///     Setzt die Daten, die in der <see cref="IViewKunde"/> angegeben sind, zurück zu den Daten, die zurzeit
        ///     in der <see cref="Datenbank.IDatenbank"/> sind
        /// </summary>
        void KundeZurücksetzen();
    }
}