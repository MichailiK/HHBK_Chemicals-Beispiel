using System.Collections.Generic;

namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <summary>
    ///     Repräsentiert die View für das einlesen oder modifizieren für <see cref="Kunde" />n
    /// </summary>
    /// <seealso cref="Kunde" />
    /// <seealso cref="IModelKunde" />
    /// <seealso cref="IControllerKunde" />
    public interface IViewKunde
    {
        IControllerKunde Controller { set; }

        int? Kundennummer { get; set; }
        string Nachname { get; set; }
        string Vorname { get; set; }
        string Strasse { get; set; }
        int Hausnummer { get; set; }
        int Postleitzahl { get; set; }
        string Ort { get; set; }
        string EmailAdresse { get; set; }

        void BestellungsListeAktualisieren(IEnumerable<string> namen);
    }
}