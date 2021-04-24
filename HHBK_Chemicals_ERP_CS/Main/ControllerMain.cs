namespace HHBK_Chemicals_ERP_CS.Main
{
    /// <inheritdoc cref="IControllerMain"/>
    public class ControllerMain : IControllerMain
    {
        public IModelMain ModelMain { private get; set; }

        public void KundeGeklickt(int index)
        {
            if (index != -1)
                ModelMain.GeklicktenKundeAnsehen(index);
        }

        public void KundeMitNummerÖffnen(int nummer)
        {
            ModelMain.KundeMitNummerÖffnen(nummer);
        }

        public void NeuenKundeErstellen()
        {
            ModelMain.NeuenKundeErstellen();
        }

        public void FormGeladen()
        {
            ModelMain.KundenListeAktualisieren();
        }
    }
}