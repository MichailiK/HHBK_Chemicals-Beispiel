using System.Collections.Generic;

namespace HHBK_Chemicals_ERP_CS.LegacyMain
{
    /// <summary>
    ///     Repräsentiert die Hauptview des Programms
    /// </summary>
    /// <seealso cref="IModelMain" />
    /// <seealso cref="IControllerMain" />
    public interface IViewMain
    {
        IControllerMain Controller { set; }

        void KundenListeAktualisieren(IEnumerable<string> namen);

        void ProduktListeAktualisieren(IEnumerable<string> namen);

        void RezeptListeAktualisieren(IEnumerable<string> namen);

        void LieferungListeAktualisieren(IEnumerable<string> namen);

        void BestellungListeAktualisieren(IEnumerable<string> namen);
    }
}