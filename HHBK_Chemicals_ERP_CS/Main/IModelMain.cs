using HHBK_Chemicals_ERP_CS.Kunden;

namespace HHBK_Chemicals_ERP_CS.Main
{
    /// <summary>
    ///     Repräsentiert das Model für das <see cref="IViewMain" />
    /// </summary>
    /// <seealso cref="IViewMain" />
    /// <seealso cref="IControllerMain"/>
    public interface IModelMain
    {
        IViewMain ViewMain { set; }

        /// <summary>
        ///     Öffnet eine <see cref="IViewKunde"/> mit den <see cref="Kunde"/>, der auf die Liste geklickt worden ist
        /// </summary>
        /// <param name="index">Index des geklickten Element auf der Liste</param>
        void GeklicktenKundeAnsehen(int index);

        /// <summary>
        ///     Öffnet eine <see cref="IViewKunde"/> mit der angegebene <see cref="Kunde.Kundennummer"/>
        /// </summary>
        /// <param name="nummer">Die <see cref="Kunde.Kundennummer"/></param>
        void KundeMitNummerÖffnen(int nummer);

        /// <summary>
        ///     Erstellt einen neuen <see cref="Kunde"/> in der Datenbank und öffnet eine <see cref="IViewKunde"/>
        /// </summary>
        void NeuenKundeErstellen();

        /// <summary>
        ///     Öffnet eine <see cref="IViewKunde"/> für den <paramref name="kunde"/>
        /// </summary>
        /// <param name="kunde">Der <see cref="Kunde"/> für den eine <see cref="IViewKunde"/> geöffnet werden soll.</param>
        void KundeAnsehen(Kunde kunde);
        void KundenListeAktualisieren();
    }
}