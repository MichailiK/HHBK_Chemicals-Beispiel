using System.Collections.Generic;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Datenbank
{
    /// <summary>
    ///     Eine Datenbank für das Speichern & Abrufen von relevanten Daten
    /// </summary>
    /// <seealso cref="FakeDatenbank"/>
    public interface IDatenbank
    {
    
        #region Kunde
    
        /// <summary>
        ///     Holt eine <see cref="IEnumerable{T}"/> von <see cref="Kunde"/>n aus der <see cref="IDatenbank"/>
        /// </summary>
        /// <returns>Einen <see cref="IEnumerable{T}" /> von Kunden</returns>
        IEnumerable<Kunde> GetKunden();

        /// <summary>
        ///     Holt einen spezifischen <see cref="Kunde"/> aus der <see cref="IDatenbank"/> mit der
        ///     <see cref="Kunde.Kundennummer" />
        /// </summary>
        /// <param name="kundennummer">Die <see cref="Kunde.Kundennummer" /> des <see cref="Kunde" />n</param>
        /// <returns>
        ///     Ein <see cref="Kunde" /> mit dieser <see cref="Kunde.Kundennummer" />, oder <c>null</c> falls solch ein
        ///     Kunde nicht existiert
        /// </returns>
        Kunde GetKunde(int kundennummer);

        /// <summary>
        ///     Löscht ein <see cref="Kunde"/> aus der <see cref="IDatenbank"/>
        /// </summary>
        /// <param name="kunde">Der Kunde, der gelöscht werden soll</param>
        /// <returns><c>true</c>, falls die Löschung erfolgreich abgeschlossen ist. Andernfalls <c>false</c></returns>
        bool DeleteKunde(Kunde kunde);

        /// <summary>
        ///     Löscht ein <see cref="Kunde"/> aus der <see cref="IDatenbank"/>
        /// </summary>
        /// <param name="kundennummer">Die <see cref="Kunde.Kundennummer"/> des <see cref="Kunde"/></param>
        /// <returns><c>true</c>, falls die Löschung erfolgreich abgeschlossen ist. Andernfalls <c>false</c></returns>
        bool DeleteKunde(int kundennummer);

        /// <summary>
        ///     Erstellt einen neuen <see cref="Kunde"/> auf der <see cref="IDatenbank"/> und gibt diese zurück.
        /// </summary>
        /// <param name="name">Der Nachname des Kunden</param>
        /// <param name="vorname">Der Vorname des Kunden</param>
        /// <returns>Der neu erstellte <see cref="Kunde"/></returns>
        Kunde CreateKunde(string name, string vorname);

        /// <summary>
        ///     Aktualisiert ein <see cref="Kunde"/> mit den neuen Daten auf der <see cref="IDatenbank"/>
        /// </summary>
        /// <param name="kunde">Der <see cref="Kunde"/> der aktualisiert werden soll</param>
        void UpdateKunde(Kunde kunde);
        
        #endregion
        
        #region Produkt
        
        /// <summary>
        ///     Holt eine <see cref="IEnumerable{T}"/> von <see cref="Produkt"/>en aus der <see cref="IDatenbank"/>
        /// </summary>
        /// <returns>Einen <see cref="IEnumerable{T}" /> von Produkten</returns>
        IEnumerable<Produkt> GetProdukte();

        /// <summary>
        ///     Holt einen spezifischen <see cref="Produkt"/> aus der <see cref="IDatenbank"/> mit der
        ///     <see cref="Produkt.Artikelnummer" />
        /// </summary>
        /// <param name="artikelnummer">Die <see cref="Produkt.Artikelnummer" /> des <see cref="Produkt" />en</param>
        /// <returns>
        ///     Ein <see cref="Produkt" /> mit dieser <see cref="Produkt.Artikelnummer" />, oder <c>null</c> falls solch
        ///     ein Produkt nicht existiert
        /// </returns>
        Produkt GetProdukt(int artikelnummer);

        /// <summary>
        ///     Löscht ein <see cref="Produkt"/> aus der <see cref="IDatenbank"/>
        /// </summary>
        /// <param name="produkt">Das Produkt, der gelöscht werden soll</param>
        /// <returns><c>true</c>, falls die Löschung erfolgreich abgeschlossen ist. Andernfalls <c>false</c></returns>
        bool DeleteProdukt(Produkt produkt);

        /// <summary>
        ///     Löscht ein <see cref="Produkt"/> aus der <see cref="IDatenbank"/>
        /// </summary>
        /// <param name="artikelnummer">Die <see cref="Produkt.Artikelnummer"/> des <see cref="Produkt"/></param>
        /// <returns><c>true</c>, falls die Löschung erfolgreich abgeschlossen ist. Andernfalls <c>false</c></returns>
        bool DeleteProdukt(int artikelnummer);

        /// <summary>
        ///     Erstellt ein neues <see cref="Produkt"/> auf der <see cref="IDatenbank"/> und gibt diese zurück.
        /// </summary>
        /// <param name="name">Der Name des Produkts</param>
        /// <returns>Das neu erstellte <see cref="Produkt"/></returns>
        Produkt CreateProdukt(string name);

        /// <summary>
        ///     Aktualisiert ein <see cref="Produkt"/> mit den neuen Daten auf der <see cref="IDatenbank"/>
        /// </summary>
        /// <param name="produkt">Das <see cref="Produkt"/> der aktualisiert werden soll</param>
        void UpdateProdukt(Produkt produkt);
        
        #endregion
        
        #region Rezept
        
        /// <summary>
        ///     Holt eine <see cref="IEnumerable{T}"/> von <see cref="Rezept"/>en aus der <see cref="IDatenbank"/>
        /// </summary>
        /// <returns>Einen <see cref="IEnumerable{T}" /> von Rezepten</returns>
        IEnumerable<Rezept> GetRezepte();

        /// <summary>
        ///     Holt einen spezifischen <see cref="Rezept"/> aus der <see cref="IDatenbank"/> mit der
        ///     <see cref="Rezept.RezeptNummer" />
        /// </summary>
        /// <param name="artikelnummer">Die <see cref="Rezept.RezeptNummer" /> des <see cref="Rezept" />en</param>
        /// <returns>
        ///     Ein <see cref="Rezept" /> mit dieser <see cref="Rezept.RezeptNummer" />, oder <c>null</c> falls solch
        ///     ein Rezept nicht existiert
        /// </returns>
        Rezept GetRezept(int artikelnummer);

        /// <summary>
        ///     Löscht ein <see cref="Rezept"/> aus der <see cref="IDatenbank"/>
        /// </summary>
        /// <param name="rezept">Das Rezept, der gelöscht werden soll</param>
        /// <returns><c>true</c>, falls die Löschung erfolgreich abgeschlossen ist. Andernfalls <c>false</c></returns>
        bool DeleteRezept(Rezept rezept);

        /// <summary>
        ///     Löscht ein <see cref="Rezept"/> aus der <see cref="IDatenbank"/>
        /// </summary>
        /// <param name="artikelnummer">Die <see cref="Rezept.RezeptNummer"/> des <see cref="Rezept"/></param>
        /// <returns><c>true</c>, falls die Löschung erfolgreich abgeschlossen ist. Andernfalls <c>false</c></returns>
        bool DeleteRezept(int artikelnummer);

        /// <summary>
        ///     Erstellt ein neues <see cref="Rezept"/> auf der <see cref="IDatenbank"/> und gibt diese zurück.
        /// </summary>
        /// <returns>Das neu erstellte <see cref="Rezept"/></returns>
        Rezept CreateRezept();

        /// <summary>
        ///     Aktualisiert ein <see cref="Rezept"/> mit den neuen Daten auf der <see cref="IDatenbank"/>
        /// </summary>
        /// <param name="rezept">Das <see cref="Rezept"/> der aktualisiert werden soll</param>
        void UpdateRezept(Rezept rezept);
        
        #endregion
    }
}