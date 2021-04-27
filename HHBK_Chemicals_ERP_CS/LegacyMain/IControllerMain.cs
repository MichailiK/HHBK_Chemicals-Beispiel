using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Lager;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.LegacyMain
{
    /// <summary>
    ///     Repräsentiert den Controller für <see cref="IViewMain" />
    /// </summary>
    /// <seealso cref="IModelMain" />
    /// <seealso cref="IViewMain" />
    public interface IControllerMain
    {
        IModelMain ModelMain { set; }

        /// <summary>
        ///     Wird aufgerufen, wenn das Form sich geladen hat
        /// </summary>
        void FormGeladen();

        #region Kunde

        /// <summary>
        ///     Wird aufgerufen, wenn auf ein Kunde in der Kundenliste doppelgeklickt wird oder Enter gedrückt wird
        /// </summary>
        /// <param name="index">Der ausgewählte index auf der Kundenliste</param>
        void KundeGeklickt(int index);

        /// <summary>
        ///     Wird aufgerufen, wenn eine Kundennummer angegeben worden ist, die eingesehen werden soll
        /// </summary>
        /// <param name="nummer">Die <see cref="Kunde.Kundennummer" /></param>
        void KundeMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Wird aufgerufen, wenn ein neuen <see cref="Kunde" /> erstellt werden soll & der neu erstellte Kunde
        ///     eingesehen werden soll
        /// </summary>
        void NeuenKundeErstellen();

        #endregion

        #region Produkt

        /// <summary>
        ///     Wird aufgerufen, wenn auf ein Produkt in der Produktliste doppelgeklickt wird oder Enter gedrückt wird
        /// </summary>
        /// <param name="index">Der ausgewählte index auf der Produktliste</param>
        void ProduktGeklickt(int index);

        /// <summary>
        ///     Wird aufgerufen, wenn ein Artikelnummer angegeben worden ist, die eingesehen werden soll
        /// </summary>
        /// <param name="nummer">Die <see cref="Produkt.Artikelnummer" /></param>
        void ProduktMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Wird aufgerufen, wenn ein neuen <see cref="Produkt" /> erstellt werden soll & der neu erstellte Produkt
        ///     eingesehen werden soll
        /// </summary>
        void NeuenProduktErstellen();

        #endregion

        #region Rezept

        /// <summary>
        ///     Wird aufgerufen, wenn auf ein Rezept in der Rezeptliste doppelgeklickt wird oder Enter gedrückt wird
        /// </summary>
        /// <param name="index">Der ausgewählte index auf der Rezeptliste</param>
        void RezeptGeklickt(int index);

        /// <summary>
        ///     Wird aufgerufen, wenn ein Artikelnummer angegeben worden ist, die eingesehen werden soll
        /// </summary>
        /// <param name="nummer">Die <see cref="Rezept.RezeptNummer" /></param>
        void RezeptMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Wird aufgerufen, wenn ein neuen <see cref="Rezept" /> erstellt werden soll & der neu erstellte Rezept
        ///     eingesehen werden soll
        /// </summary>
        void NeuenRezeptErstellen();

        #endregion

        #region Lieferung

        /// <summary>
        ///     Wird aufgerufen, wenn auf eine Lieferung in der Lieferungsliste doppelgeklickt wird oder Enter gedrückt
        ///     wird
        /// </summary>
        /// <param name="index">Der ausgewählte index auf der Lieferungsliste</param>
        void LieferungGeklickt(int index);

        /// <summary>
        ///     Wird aufgerufen, wenn ein Lieferung ID angegeben worden ist, die eingesehen werden soll
        /// </summary>
        /// <param name="nummer">Die <see cref="Lieferposition.Id" /></param>
        void LieferungMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Wird aufgerufen, wenn eine neue <see cref="Lieferposition" /> erstellt werden soll & der neu erstellte
        ///     Lieferung eingesehen werden soll
        /// </summary>
        void NeueLieferungErstellen();

        #endregion

        #region Bestellung

        /// <summary>
        ///     Wird aufgerufen, wenn auf eine Bestellung in der Bestellungsliste doppelgeklickt wird oder Enter gedrückt
        ///     wird
        /// </summary>
        /// <param name="index">Der ausgewählte index auf der Bestellungsliste</param>
        void BestellungGeklickt(int index);

        /// <summary>
        ///     Wird aufgerufen, wenn ein Bestellpositionsnummer angegeben worden ist, die eingesehen werden soll
        /// </summary>
        /// <param name="nummer">Die <see cref="Bestellposition.Bestellpositionsnummer" /></param>
        void BestellungMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Wird aufgerufen, wenn eine neue <see cref="Bestellposition" /> erstellt werden soll & der neu erstellte
        ///     Bestellung eingesehen werden soll
        /// </summary>
        void NeueBestellungErstellen();

        #endregion
    }
}