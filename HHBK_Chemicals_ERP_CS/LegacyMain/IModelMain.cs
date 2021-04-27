using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Lager;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.LegacyMain
{
    /// <summary>
    ///     Repräsentiert das Model für das <see cref="IViewMain" />
    /// </summary>
    /// <seealso cref="IViewMain" />
    /// <seealso cref="IControllerMain" />
    public interface IModelMain
    {
        IViewMain ViewMain { set; }

        #region Kunde

        /// <summary>
        ///     Öffnet eine <see cref="IViewKunde" /> mit den <see cref="Kunde" />, der auf die Liste geklickt worden ist
        /// </summary>
        /// <param name="index">Index des geklickten Element auf der Liste</param>
        void GeklicktenKundeAnsehen(int index);

        /// <summary>
        ///     Öffnet eine <see cref="IViewKunde" /> mit der angegebene <see cref="Kunde.Kundennummer" />
        /// </summary>
        /// <param name="nummer">Die <see cref="Kunde.Kundennummer" /></param>
        void KundeMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Erstellt einen neuen <see cref="Kunde" /> in der Datenbank und öffnet eine <see cref="IViewKunde" />
        /// </summary>
        void NeuenKundeErstellen();

        /// <summary>
        ///     Öffnet eine <see cref="IViewKunde" /> für den <paramref name="kunde" />
        /// </summary>
        /// <param name="kunde">
        ///     Der <see cref="Kunde" /> für den eine <see cref="IViewKunde" /> geöffnet werden soll
        /// </param>
        void KundeAnsehen(Kunde kunde);

        /// <summary>
        ///     Aktualisiert die Kundeliste auf der <see cref="IViewKunde" />
        /// </summary>
        void KundenListeAktualisieren();

        #endregion

        #region Produkt

        /// <summary>
        ///     Öffnet eine <see cref="IViewProdukt" /> mit den <see cref="Produkt" />, der auf die Liste geklickt worden
        ///     ist
        /// </summary>
        /// <param name="index">Index des geklickten Element auf der Liste</param>
        void GeklicktenProduktAnsehen(int index);

        /// <summary>
        ///     Öffnet eine <see cref="IViewProdukt" /> mit der angegebene <see cref="Produkt.Artikelnummer" />
        /// </summary>
        /// <param name="nummer">Die <see cref="Produkt.Artikelnummer" /></param>
        void ProduktMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Erstellt ein neues <see cref="Produkt" /> in der Datenbank und öffnet eine <see cref="IViewProdukt" />
        /// </summary>
        void NeuenProduktErstellen();

        /// <summary>
        ///     Öffnet eine <see cref="IViewProdukt" /> für den <paramref name="produkt" />
        /// </summary>
        /// <param name="produkt">
        ///     Der <see cref="Produkt" /> für den eine <see cref="IViewProdukt" /> geöffnet werden soll
        /// </param>
        void ProduktAnsehen(Produkt produkt);

        /// <summary>
        ///     Aktualisiert die Produktliste auf der <see cref="IViewProdukt" />
        /// </summary>
        void ProduktListeAktualisieren();

        #endregion

        #region Rezept

        /// <summary>
        ///     Öffnet eine <see cref="IViewRezept" /> mit den <see cref="Rezept" />, der auf die Liste geklickt worden
        ///     ist
        /// </summary>
        /// <param name="index">Index des geklickten Element auf der Liste</param>
        void GeklicktenRezeptAnsehen(int index);

        /// <summary>
        ///     Öffnet eine <see cref="IViewRezept" /> mit der angegebene <see cref="Rezept.RezeptNummer" />
        /// </summary>
        /// <param name="nummer">Die <see cref="Rezept.RezeptNummer" /></param>
        void RezeptMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Erstellt ein neues <see cref="Rezept" /> in der Datenbank und öffnet eine <see cref="IViewRezept" />
        /// </summary>
        void NeuenRezeptErstellen();

        /// <summary>
        ///     Öffnet eine <see cref="IViewRezept" /> für den <paramref name="rezept" />
        /// </summary>
        /// <param name="rezept">
        ///     Der <see cref="Rezept" /> für den eine <see cref="IViewRezept" /> geöffnet werden soll
        /// </param>
        void RezeptAnsehen(Rezept rezept);

        /// <summary>
        ///     Aktualisiert die Rezeptliste auf der <see cref="IViewRezept" />
        /// </summary>
        void RezeptListeAktualisieren();

        #endregion

        #region Lieferung

        /// <summary>
        ///     Öffnet eine <see cref="IViewLieferposition" /> mit den <see cref="Lieferposition" />, der auf die Liste geklickt
        ///     worden
        ///     ist
        /// </summary>
        /// <param name="index">Index des geklickten Element auf der Liste</param>
        void GeklickteLieferungAnsehen(int index);

        /// <summary>
        ///     Öffnet eine <see cref="IViewLieferposition" /> mit der angegebene <see cref="Lieferposition.Id" />
        /// </summary>
        /// <param name="nummer">Die <see cref="Lieferposition.Id" /></param>
        void LieferungMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Erstellt eine neue <see cref="Lieferposition" /> in der Datenbank und öffnet eine
        ///     <see cref="IViewLieferposition" />
        /// </summary>
        void NeueLieferungErstellen();

        /// <summary>
        ///     Öffnet eine <see cref="IViewLieferposition" /> für den <paramref name="lieferung" />
        /// </summary>
        /// <param name="lieferung">
        ///     Die <see cref="Lieferposition" /> für den eine <see cref="IViewLieferposition" /> geöffnet werden soll
        /// </param>
        void LieferungAnsehen(Lieferposition lieferung);

        /// <summary>
        ///     Aktualisiert die Lieferungliste auf der <see cref="IViewLieferposition" />
        /// </summary>
        void LieferungListeAktualisieren();

        #endregion

        #region Bestellung

        /// <summary>
        ///     Öffnet eine <see cref="IViewBestellposition" /> mit den <see cref="Bestellposition" />, der auf die Liste geklickt
        ///     worden
        ///     ist
        /// </summary>
        /// <param name="index">Index des geklickten Element auf der Liste</param>
        void GeklickteBestellungAnsehen(int index);

        /// <summary>
        ///     Öffnet eine <see cref="IViewBestellposition" /> mit der angegebene
        ///     <see cref="Bestellposition.Bestellpositionsnummer" />
        /// </summary>
        /// <param name="nummer">Die <see cref="Bestellposition.Bestellpositionsnummer" /></param>
        void BestellungMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Erstellt eine neue <see cref="Bestellposition" /> in der Datenbank und öffnet eine
        ///     <see cref="IViewBestellposition" />
        /// </summary>
        void NeueBestellungErstellen();

        /// <summary>
        ///     Öffnet eine <see cref="IViewBestellposition" /> für den <paramref name="bestellposition" />
        /// </summary>
        /// <param name="bestellposition">
        ///     Die <see cref="Bestellposition" /> für den eine <see cref="IViewBestellposition" /> geöffnet werden soll
        /// </param>
        void BestellungAnsehen(Bestellposition bestellposition);

        /// <summary>
        ///     Aktualisiert die Bestellungliste auf der <see cref="IViewBestellposition" />
        /// </summary>
        void BestellungListeAktualisieren();

        #endregion
    }
}