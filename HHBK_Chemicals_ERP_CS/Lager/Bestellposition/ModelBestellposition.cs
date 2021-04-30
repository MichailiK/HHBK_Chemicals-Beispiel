using System;
using System.Windows.Forms;
using HHBK_Chemicals_ERP_CS.Datenbank;
using HHBK_Chemicals_ERP_CS.Kunden;
using HHBK_Chemicals_ERP_CS.Produktion;

namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <inheritdoc cref="IModelBestellposition" />
    public class ModelBestellposition : IModelBestellposition
    {
        private readonly Bestellposition _bestellposition;
        private readonly IDatenbank _datenbank;

        public ModelBestellposition(IDatenbank datenbank, Bestellposition bestellposition)
        {
            _datenbank = datenbank;
            _bestellposition = bestellposition;
        }

        public IViewBestellposition ViewBestellposition { private get; set; }


        public void ProduktÖffnen(int artikelnummer)
        {
            var produkt = _datenbank.GetProdukt(artikelnummer);
            if (produkt == null)
            {
                MessageBox.Show("Das Produkt konnte nicht gefunden werden", "Produkt nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var viewProdukt = new ViewProdukt();
            var modelProdukt = new ModelProdukt(_datenbank, produkt);
            var controllerProdukt = new ControllerProdukt(modelProdukt);

            viewProdukt.Controller = controllerProdukt;
            controllerProdukt.ModelProdukt = modelProdukt;
            modelProdukt.ViewProdukt = viewProdukt;

            viewProdukt.ShowDialog();
        }

        public void KundeÖffnen(int kundennummer)
        {
            var kunde = _datenbank.GetKunde(kundennummer);
            if (kunde == null)
            {
                MessageBox.Show("Der Kunde konnte nicht gefunden werden", "Kunde nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var viewKunde = new ViewKunde();
            var modelKunde = new ModelKunde(_datenbank, kunde);
            var controllerKunde = new ControllerKunde(modelKunde);

            viewKunde.Controller = controllerKunde;
            controllerKunde.ModelKunde = modelKunde;
            modelKunde.ViewKunde = viewKunde;

            viewKunde.ShowDialog();
        }

        public void LieferpositionÖffnen(int lieferpositionId)
        {
            var lieferung = _datenbank.GetLieferposition(lieferpositionId);
            if (lieferung == null)
            {
                MessageBox.Show("Die Lieferung konnte nicht gefunden werden", "Lieferung nicht gefunden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var viewLieferung = new ViewLieferposition();
            var modelLieferung = new ModelLieferposition(_datenbank, lieferung);
            var controllerLieferung = new ControllerLieferposition(modelLieferung);

            viewLieferung.Controller = controllerLieferung;
            controllerLieferung.ModelLieferposition = modelLieferung;
            modelLieferung.ViewLieferposition = viewLieferung;

            viewLieferung.ShowDialog();
        }

        public void BestellpositionAktualisieren()
        {
            var produkt = _datenbank.GetProdukt(ViewBestellposition.ArtikelNummer);
            if (produkt == null)
                throw new ArgumentException("Das Produkt konnte nicht gefunden werden");
            

            var kunde = _datenbank.GetKunde(ViewBestellposition.Kundennummer);
            if (kunde == null)
                throw new ArgumentException("Der Kunde konnte nicht gefunden werden");

            var lieferposition = _datenbank.GetLieferposition(ViewBestellposition.LieferpositionId);
            if (lieferposition == null)
                throw new ArgumentException("Die Lieferung konnte nicht gefunden werden");


            _bestellposition.Produkt = produkt;
            _bestellposition.Bestellungsnummer = ViewBestellposition.Bestellungsnummer;
            _bestellposition.Bestelldatum = ViewBestellposition.Bestelldatum;
            _bestellposition.Kunde = kunde;
            _bestellposition.Lieferposition = lieferposition;

            _datenbank.UpdateBestellposition(_bestellposition);
        }

        public void BestellpositionZurücksetzen()
        {
            ViewBestellposition.Bestellpositionsnummer = _bestellposition.Bestellpositionsnummer;
            ViewBestellposition.ArtikelNummer = _bestellposition.Produkt?.Artikelnummer ?? 0;
            ViewBestellposition.Bestellungsnummer = _bestellposition.Bestellungsnummer;
            ViewBestellposition.Menge = _bestellposition.Menge;
            ViewBestellposition.Bestelldatum = _bestellposition.Bestelldatum;
            ViewBestellposition.Kundennummer = _bestellposition.Kunde?.Kundennummer ?? 0;
            ViewBestellposition.LieferpositionId = _bestellposition.Lieferposition?.Id ?? 0;
        }

        public void BestellpositionLöschen()
        {
            _datenbank.DeleteBestellposition(_bestellposition);
        }
    }
}