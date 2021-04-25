using System;
using HHBK_Chemicals_ERP_CS.Datenbank;

namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <inheritdoc cref="IModelRezept" />
    public class ModelRezept : IModelRezept
    {
        private readonly IDatenbank _datenbank;
        private readonly Rezept _rezept;

        public ModelRezept(IDatenbank datenbank, Rezept rezept)
        {
            _datenbank = datenbank;
            _rezept = rezept;
        }

        public IViewRezept ViewRezept { private get; set; }

        public void RezeptAktualisieren()
        {
            var produkt = _datenbank.GetProdukt(ViewRezept.ArtikelNummer);
            if (produkt == null)
                throw new ArgumentException("Das Produkt mit der Artikelnummer " +
                                            ViewRezept.ArtikelNummer +
                                            " konnte nicht gefunden werden");

            _rezept.HerstellungsdauerMin = ViewRezept.HerstellungsdauerMin;
            _rezept.Produkt = produkt;

            _datenbank.UpdateRezept(_rezept);
        }

        public void RezeptZurücksetzen()
        {
            ViewRezept.RezeptNummer = _rezept.RezeptNummer;
            ViewRezept.HerstellungsdauerMin = _rezept.HerstellungsdauerMin;
            ViewRezept.ArtikelNummer = _rezept.Produkt?.Artikelnummer ?? 0;
        }

        public void RezeptLöschen()
        {
            _datenbank.DeleteRezept(_rezept);
        }
    }
}