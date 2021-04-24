using System.Collections.Generic;
using HHBK_Chemicals_ERP_CS.Kunden;

namespace HHBK_Chemicals_ERP_CS.Datenbank
{
    /// <summary>
    ///     Eine Datenbank für das speichern von Daten
    /// </summary>
    /// <seealso cref="FakeDatenbank"/>
    public interface IDatenbank
    {
        /// <summary>
        ///     Holt eine Liste von Kunden aus der Datenbank
        /// </summary>
        /// <returns>Einen <see cref="IEnumerable{T}" /> von Kunden</returns>
        IEnumerable<Kunde> GetKunden();

        /// <summary>
        ///     Holt einen spezifischen Kunde aus der Datenbank mit der <see cref="Kunde.Kundennummer" />
        /// </summary>
        /// <param name="kundennummer">Die <see cref="Kunde.Kundennummer" /> des <see cref="Kunde" />n</param>
        /// <returns>
        ///     Der <see cref="Kunde" /> mit der <see cref="Kunde.Kundennummer" />, oder <c>null</c> falls solch ein
        ///     Kunde nicht existiert
        /// </returns>
        Kunde GetKunde(int kundennummer);

        /// <summary>
        ///     Löscht ein Kunde aus den Datenbank
        /// </summary>
        /// <param name="kunde">Der Kunde, der gelöscht werden soll</param>
        /// <returns><c>true</c>, falls die Löschung erfolgreich abgeschlossen ist. Andernfalls <c>false</c></returns>
        bool DeleteKunde(Kunde kunde);

        bool DeleteKunde(int kundennummer);

        Kunde CreateKunde(string name, string vorname);

        void UpdateKunde(Kunde kunde);
    }
}