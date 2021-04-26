namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <inheritdoc cref="IControllerBestellposition" />
    public class ControllerBestellposition : IControllerBestellposition
    {
        public ControllerBestellposition(IModelBestellposition modelBestellposition)
        {
            ModelBestellposition = modelBestellposition;
        }

        public IModelBestellposition ModelBestellposition { private get; set; }

        public void ProduktÖffnen(int artikelnummer)
        {
            ModelBestellposition.ProduktÖffnen(artikelnummer);
        }

        public void KundeÖffnen(int kundennummer)
        {
            ModelBestellposition.KundeÖffnen(kundennummer);
        }

        public void LieferpositionÖffnen(int lieferpositionId)
        {
            ModelBestellposition.LieferpositionÖffnen(lieferpositionId);
        }

        public void BestellpositionAktualisieren()
        {
            ModelBestellposition.BestellpositionAktualisieren();
        }

        public void BestellpositionLöschen()
        {
            ModelBestellposition.BestellpositionLöschen();
        }

        public void FormGeladen()
        {
            ModelBestellposition.BestellpositionZurücksetzen();
        }
    }
}