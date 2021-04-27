namespace HHBK_Chemicals_ERP_CS.Main
{
    /// <inheritdoc cref="IControllerMain" />
    public class ControllerMain : IControllerMain
    {
        public IModelMain ModelMain { private get; set; }


        public void FormGeladen()
        {
            ModelMain.KundenListeAktualisieren();
            ModelMain.ProduktListeAktualisieren();
        }

        #region Kunde

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

        #endregion

        #region Produkt

        public void ProduktGeklickt(int index)
        {
            if (index != -1)
                ModelMain.GeklicktenProduktAnsehen(index);
        }

        public void ProduktMitNummerÖffnen(int nummer)
        {
            ModelMain.ProduktMitNummerÖffnen(nummer);
        }

        public void NeuenProduktErstellen()
        {
            ModelMain.NeuenProduktErstellen();
        }

        #endregion
    }
}