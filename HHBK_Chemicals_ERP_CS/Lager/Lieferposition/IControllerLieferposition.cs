namespace HHBK_Chemicals_ERP_CS.Lager.Lieferposition
{
    /// <summary>
    ///     Repräsentiert den Controller für <see cref="IModelLieferposition" />
    /// </summary>
    /// <seealso cref="Lieferposition" />
    /// <seealso cref="IModelLieferposition" />
    /// <seealso cref="IViewLieferposition" />
    public interface IControllerLieferposition
    {
        IModelLieferposition ModelLieferposition { set; }

        /// <summary>
        ///     Aktualisiert die Lieferposition mit den neuen Daten, die im Form angegeben sind
        /// </summary>
        void LieferpositionAktualisieren();

        /// <summary>
        ///     Löscht die Lieferposition aus der Datenbank
        /// </summary>
        void LieferpositionLöschen();

        /// <summary>
        ///     Wird aufgerufen, wenn das Form sich geladen hat
        /// </summary>
        void FormGeladen();
    }
}