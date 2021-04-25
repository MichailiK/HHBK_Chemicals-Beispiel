namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert den Controller für <see cref="IModelProdukt" />
    /// </summary>
    /// <seealso cref="Produkt"/>
    /// <seealso cref="IModelProdukt"/>
    /// <seealso cref="IViewProdukt"/>
    public interface IControllerProdukt
    {
        IModelProdukt ModelProdukt { set; }

        /// <summary>
        ///     Aktualisiert den Produkten mit den neuen Daten, die im Form angegeben sind.
        /// </summary>
        void ProduktAktualisieren();

        /// <summary>
        ///     Löscht den Produkten aus der Datenbank
        /// </summary>
        void ProduktLöschen();

        /// <summary>
        ///     Wird aufgerufen, wenn das Form sich geladen hat
        /// </summary>
        void FormGeladen();
    }
}