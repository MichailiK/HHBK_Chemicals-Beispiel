namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert den Controller für <see cref="IModelRezept" />
    /// </summary>
    /// <seealso cref="Rezept"/>
    /// <seealso cref="IModelRezept"/>
    /// <seealso cref="IViewRezept"/>
    public interface IControllerRezept
    {
        IModelRezept ModelRezept { set; }

        /// <summary>
        ///     Aktualisiert den Rezept mit den neuen Daten, die im Form angegeben sind.
        /// </summary>
        void RezeptAktualisieren();

        /// <summary>
        ///     Löscht den Rezept aus der Datenbank
        /// </summary>
        void RezeptLöschen();

        /// <summary>
        ///     Wird aufgerufen, wenn das Form sich geladen hat
        /// </summary>
        void FormGeladen();
    }
}