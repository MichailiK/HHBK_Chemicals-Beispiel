namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <inheritdoc cref="IControllerRezept" />
    public class ControllerRezept : IControllerRezept
    {
        public ControllerRezept(IModelRezept modelRezept)
        {
            ModelRezept = modelRezept;
        }

        public IModelRezept ModelRezept { private get; set; }

        public void ProduktÖffnen(int artikelnummer)
        {
            ModelRezept.ProduktÖffnen(artikelnummer);
        }

        public void RezeptAktualisieren()
        {
            ModelRezept.RezeptAktualisieren();
        }

        public void RezeptLöschen()
        {
            ModelRezept.RezeptLöschen();
        }

        public void FormGeladen()
        {
            ModelRezept.RezeptZurücksetzen();
        }
    }
}