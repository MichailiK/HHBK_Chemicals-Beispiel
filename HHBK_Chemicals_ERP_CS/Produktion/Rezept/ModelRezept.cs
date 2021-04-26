using System;
using System.Windows.Forms;
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

        public void ProduktÖffnen(int artikelnummer)
        {
            var produkt = _datenbank.GetProdukt(artikelnummer);
            if (produkt == null)
                MessageBox.Show("Das Produkt konnte nicht gefunden werden", "Produkt nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                var viewProdukt = new ViewProdukt();
                var modelProdukt = new ModelProdukt(_datenbank, produkt);
                var controllerProdukt = new ControllerProdukt(modelProdukt);

                viewProdukt.Controller = controllerProdukt;
                controllerProdukt.ModelProdukt = modelProdukt;
                modelProdukt.ViewProdukt = viewProdukt;

                viewProdukt.ShowDialog();
            }
        }

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