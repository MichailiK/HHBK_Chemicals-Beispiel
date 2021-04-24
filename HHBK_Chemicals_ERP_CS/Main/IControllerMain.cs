using HHBK_Chemicals_ERP_CS.Kunden;

namespace HHBK_Chemicals_ERP_CS.Main
{
    /// <summary>
    ///     Repräsentiert den Controller für <see cref="IViewMain" />
    /// </summary>
    /// <seealso cref="IModelMain"/>
    /// <seealso cref="IViewMain"/>
    public interface IControllerMain
    {
        IModelMain ModelMain { set; }

        /// <summary>
        ///     Wird aufgerufen, wenn auf ein Kunde in der Kundenliste doppelgeklickt wird oder Enter gedrückt wird
        /// </summary>
        /// <param name="index">Der ausgewählte index auf der Kundenliste</param>
        void KundeGeklickt(int index);
        
        /// <summary>
        ///     Wird aufgerufen, wenn eine Kundennummer angegeben worden ist, die eingesehen werden soll
        /// </summary>
        /// <param name="nummer">Die <see cref="Kunde.Kundennummer"/></param>
        void KundeMitNummerÖffnen(int nummer);
        
        /// <summary>
        ///     Wird aufgerufen, wenn ein neuen <see cref="Kunde"/> erstellt werden soll & der neu erstellte Kunde
        ///     eingesehen werden soll.
        /// </summary>
        void NeuenKundeErstellen();

        /// <summary>
        ///     Wird aufgerufen, wenn das Form sich geladen hat
        /// </summary>
        void FormGeladen();
    }
}