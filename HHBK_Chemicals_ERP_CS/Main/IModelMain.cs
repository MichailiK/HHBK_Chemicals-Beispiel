using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Lager;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Main
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
    }
}