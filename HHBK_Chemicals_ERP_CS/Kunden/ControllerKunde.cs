namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <inheritdoc cref="IControllerKunde" />
    public class ControllerKunde : IControllerKunde
    {
        public ControllerKunde(IModelKunde modelKunde)
        {
            ModelKunde = modelKunde;
        }

        public IModelKunde ModelKunde { private get; set; }

        public void KundeAktualisieren()
        {
            ModelKunde.KundeAktualisieren();
        }

        public void KundeLöschen()
        {
            ModelKunde.KundeLöschen();
        }

        public void FormGeladen()
        {
            ModelKunde.KundeZurücksetzen();
        }
    }
}