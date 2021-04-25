namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <inheritdoc cref="IControllerProdukt" />
    public class ControllerProdukt : IControllerProdukt
    {
        public ControllerProdukt(IModelProdukt modelProdukt)
        {
            ModelProdukt = modelProdukt;
        }

        public IModelProdukt ModelProdukt { private get; set; }

        public void ProduktAktualisieren()
        {
            ModelProdukt.ProduktAktualisieren();
        }

        public void ProduktLöschen()
        {
            ModelProdukt.ProduktLöschen();
        }

        public void FormGeladen()
        {
            ModelProdukt.ProduktZurücksetzen();
        }
    }
}