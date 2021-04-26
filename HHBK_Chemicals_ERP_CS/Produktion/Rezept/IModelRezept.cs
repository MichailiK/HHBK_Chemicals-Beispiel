namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert das Model für das <see cref="IViewRezept" />
    /// </summary>
    /// <seealso cref="Rezept" />
    /// <seealso cref="IViewRezept" />
    /// <seealso cref="IControllerRezept" />
    public interface IModelRezept
    {
        IViewRezept ViewRezept { set; }

        /// <summary>
        ///     Öffnet eine <see cref="IViewProdukt"/> mit der angegeben <see cref="Produkt.Artikelnummer"/>
        /// </summary>
        /// <param name="artikelnummer">Die <see cref="Produkt.Artikelnummer"/></param>
        void ProduktÖffnen(int artikelnummer);

        /// <summary>
        ///     Aktualisiert den <see cref="Rezept" /> mit den neuen Daten, die in der <see cref="IViewRezept" /> angegeben
        ///     sind
        /// </summary>
        void RezeptAktualisieren();

        /// <summary>
        ///     Löscht den <see cref="Rezept" /> aus der <see cref="Datenbank.IDatenbank" />
        /// </summary>
        void RezeptLöschen();

        /// <summary>
        ///     Setzt die Daten, die in der <see cref="IViewRezept" /> angegeben sind, zurück zu den Daten, die zurzeit
        ///     in der <see cref="Datenbank.IDatenbank" /> sind
        /// </summary>
        void RezeptZurücksetzen();
    }
}