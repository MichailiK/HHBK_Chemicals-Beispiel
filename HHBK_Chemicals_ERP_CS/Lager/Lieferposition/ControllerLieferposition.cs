namespace HHBK_Chemicals_ERP_CS.Lager.Lieferposition
{
    /// <inheritdoc cref="IControllerLieferposition" />
    public class ControllerLieferposition : IControllerLieferposition
    {
        public ControllerLieferposition(IModelLieferposition modelLieferposition)
        {
            ModelLieferposition = modelLieferposition;
        }

        public IModelLieferposition ModelLieferposition { private get; set; }

        public void LieferpositionAktualisieren()
        {
            ModelLieferposition.LieferpositionAktualisieren();
        }

        public void LieferpositionLöschen()
        {
            ModelLieferposition.LieferpositionLöschen();
        }

        public void FormGeladen()
        {
            ModelLieferposition.LieferpositionZurücksetzen();
        }
    }
}