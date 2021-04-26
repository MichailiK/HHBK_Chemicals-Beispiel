namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <summary>
    ///     Repräsentiert das Model für die <see cref="IViewLieferposition" />
    /// </summary>
    /// <seealso cref="Lieferposition" />
    /// <seealso cref="IViewLieferposition" />
    /// <seealso cref="IControllerLieferposition" />
    public interface IModelLieferposition
    {
        IViewLieferposition ViewLieferposition { set; }

        /// <summary>
        ///     Aktualisiert die <see cref="Lieferposition" /> mit den neuen Daten, die in der
        ///     <see cref="IViewLieferposition" /> angegeben sind
        /// </summary>
        void LieferpositionAktualisieren();

        /// <summary>
        ///     Löscht die <see cref="Lieferposition" /> aus der <see cref="Datenbank.IDatenbank" />
        /// </summary>
        void LieferpositionLöschen();

        /// <summary>
        ///     Setzt die Daten, die in der <see cref="IViewLieferposition" /> angegeben sind, zurück zu den Daten, die
        ///     zurzeit in der <see cref="Datenbank.IDatenbank" /> sind
        /// </summary>
        void LieferpositionZurücksetzen();
    }
}