using HHBK_Chemicals_ERP_CS.Datenbank;

namespace HHBK_Chemicals_ERP_CS.Lager.Lieferposition
{
    /// <inheritdoc cref="IModelLieferposition" />
    public class ModelLieferposition : IModelLieferposition
    {
        private readonly IDatenbank _datenbank;
        private readonly Lieferposition _lieferposition;

        public ModelLieferposition(IDatenbank datenbank, Lieferposition lieferposition)
        {
            _datenbank = datenbank;
            _lieferposition = lieferposition;
        }

        public IViewLieferposition ViewLieferposition { private get; set; }

        public void LieferpositionAktualisieren()
        {
            _lieferposition.Liefernummer = ViewLieferposition.Liefernummer;
            _lieferposition.Versanddatum = ViewLieferposition.Versanddatum;
            _lieferposition.Lieferdatum = ViewLieferposition.Lieferdatum;
            _lieferposition.NameVersandkontrolle = ViewLieferposition.NameVersandKontrolle;
            _lieferposition.NameSpedition = ViewLieferposition.NameSpedition;

            _datenbank.UpdateLieferposition(_lieferposition);
        }

        public void LieferpositionZurücksetzen()
        {
            ViewLieferposition.Id = _lieferposition.Id;
            ViewLieferposition.Liefernummer = _lieferposition.Liefernummer;
            ViewLieferposition.Versanddatum = _lieferposition.Versanddatum;
            ViewLieferposition.Lieferdatum = _lieferposition.Lieferdatum;
            ViewLieferposition.NameVersandKontrolle = _lieferposition.NameVersandkontrolle;
            ViewLieferposition.NameSpedition = _lieferposition.NameSpedition;
        }

        public void LieferpositionLöschen()
        {
            _datenbank.DeleteLieferposition(_lieferposition);
        }
    }
}