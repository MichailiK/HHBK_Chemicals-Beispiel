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
    }
}