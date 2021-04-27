using HHBK_Chemicals_ERP_CS.LegacyMain;

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
            ModelKunde.BestellungListeAktualisieren();;
        }

        #region Bestellung

        public void BestellungGeklickt(int index)
        {
            if (index != -1)
                ModelKunde.GeklickteBestellungAnsehen(index);
        }

        public void BestellungMitNummerÖffnen(int nummer)
        {
            ModelKunde.BestellungMitNummerÖffnen(nummer);
        }

        public void NeueBestellungErstellen()
        {
            ModelKunde.NeueBestellungErstellen();
        }

        #endregion
    }
}