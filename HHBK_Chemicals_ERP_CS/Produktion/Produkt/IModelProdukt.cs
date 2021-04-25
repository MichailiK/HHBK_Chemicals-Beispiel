namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <summary>
    ///     Repräsentiert das Model für das <see cref="IViewProdukt" />
    /// </summary>
    /// <seealso cref="Produkt"/>
    /// <seealso cref="IViewProdukt" />
    /// <seealso cref="IControllerProdukt"/>
    public interface IModelProdukt
    {
        IViewProdukt ViewProdukt { set; }

        /// <summary>
        ///     Aktualisiert den <see cref="Produkt"/> mit den neuen Daten, die in der <see cref="IViewProdukt"/> angegeben
        ///     sind
        /// </summary>
        void ProduktAktualisieren();

        /// <summary>
        ///     Löscht den <see cref="Produkt"/> aus der <see cref="Datenbank.IDatenbank"/>
        /// </summary>
        void ProduktLöschen();
        
        /// <summary>
        ///     Setzt die Daten, die in der <see cref="IViewProdukt"/> angegeben sind, zurück zu den Daten, die zurzeit
        ///     in der <see cref="Datenbank.IDatenbank"/> sind
        /// </summary>
        void ProduktZurücksetzen();
    }
}