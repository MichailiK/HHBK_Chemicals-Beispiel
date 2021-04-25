using HHBK_Chemicals_ERP_CS.Datenbank;

namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <inheritdoc cref="IModelProdukt" />
    public class ModelProdukt : IModelProdukt
    {
        private readonly IDatenbank _datenbank;
        private readonly Produkt _produkt;

        public ModelProdukt(IDatenbank datenbank, Produkt produkt)
        {
            _datenbank = datenbank;
            _produkt = produkt;
        }

        public IViewProdukt ViewProdukt { private get; set; }

        public void ProduktAktualisieren()
        {
            _produkt.Name = ViewProdukt.ProduktName;
            _produkt.Verkaufseinheit = ViewProdukt.Verkaufseinheit;
            _produkt.Einheit = ViewProdukt.Einheit;
            _produkt.PreisVk = ViewProdukt.PreisVk;

            _datenbank.UpdateProdukt(_produkt);
        }

        public void ProduktZurücksetzen()
        {
            ViewProdukt.Artikelnummer = _produkt.Artikelnummer;
            ViewProdukt.ProduktName = _produkt.Name;
            ViewProdukt.Verkaufseinheit = _produkt.Verkaufseinheit;
            ViewProdukt.Einheit = _produkt.Einheit;
            ViewProdukt.PreisVk = _produkt.PreisVk;
        }

        public void ProduktLöschen()
        {
            _datenbank.DeleteProdukt(_produkt);
        }
    }
}