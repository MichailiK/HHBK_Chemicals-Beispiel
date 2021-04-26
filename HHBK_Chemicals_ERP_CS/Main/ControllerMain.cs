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
            ModelMain.RezeptListeAktualisieren();
            ModelMain.LieferungListeAktualisieren();
            ModelMain.BestellungListeAktualisieren();
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

        #region Rezept

        public void RezeptGeklickt(int index)
        {
            if (index != -1)
                ModelMain.GeklicktenRezeptAnsehen(index);
        }

        public void RezeptMitNummerÖffnen(int nummer)
        {
            ModelMain.RezeptMitNummerÖffnen(nummer);
        }

        public void NeuenRezeptErstellen()
        {
            ModelMain.NeuenRezeptErstellen();
        }

        #endregion

        #region Lieferung

        public void LieferungGeklickt(int index)
        {
            if (index != -1)
                ModelMain.GeklickteLieferungAnsehen(index);
        }

        public void LieferungMitNummerÖffnen(int nummer)
        {
            ModelMain.LieferungMitNummerÖffnen(nummer);
        }

        public void NeueLieferungErstellen()
        {
            ModelMain.NeueLieferungErstellen();
        }

        #endregion

        #region Bestellung

        public void BestellungGeklickt(int index)
        {
            if (index != -1)
                ModelMain.GeklickteBestellungAnsehen(index);
        }

        public void BestellungMitNummerÖffnen(int nummer)
        {
            ModelMain.BestellungMitNummerÖffnen(nummer);
        }

        public void NeueBestellungErstellen()
        {
            ModelMain.NeueBestellungErstellen();
        }

        #endregion
    }
}