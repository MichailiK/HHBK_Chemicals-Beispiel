using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS.LegacyMain
{
    /// <inheritdoc cref="IViewMain" />
    public partial class ViewMain : Form, IViewMain
    {
        public ViewMain()
        {
            InitializeComponent();
        }

        public IControllerMain Controller { private get; set; }

        public void KundenListeAktualisieren(IEnumerable<string> namen)
        {
            kundenListBox.Items.Clear();
            kundenListBox.Items.AddRange(namen.Cast<object>().ToArray());
        }

        public void ProduktListeAktualisieren(IEnumerable<string> namen)
        {
            produkteListBox.Items.Clear();
            produkteListBox.Items.AddRange(namen.Cast<object>().ToArray());
        }

        public void RezeptListeAktualisieren(IEnumerable<string> namen)
        {
            rezeptListBox.Items.Clear();
            rezeptListBox.Items.AddRange(namen.Cast<object>().ToArray());
        }

        public void LieferungListeAktualisieren(IEnumerable<string> namen)
        {
            lieferungListBox.Items.Clear();
            lieferungListBox.Items.AddRange(namen.Cast<object>().ToArray());
        }

        public void BestellungListeAktualisieren(IEnumerable<string> namen)
        {
            bestellungenListBox.Items.Clear();
            bestellungenListBox.Items.AddRange(namen.Cast<object>().ToArray());
        }

        #region Events

        private void ViewMain_Load(object sender, EventArgs e)
        {
            Controller.FormGeladen();
        }

        #region Kunde

        private void kundenListBox_DoubleClick(object sender, EventArgs e)
        {
            Controller.KundeGeklickt(kundenListBox.SelectedIndex);
        }

        private void kundenListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Controller.KundeGeklickt(kundenListBox.SelectedIndex);
        }


        private void kundeNummerAufrufenButton_Click(object sender, EventArgs e)
        {
            Controller.KundeMitNummerÖffnen((int) kundenNummerAufrufenNumericUpDown.Value);
        }


        private void neuenKundeButton_Click(object sender, EventArgs e)
        {
            Controller.NeuenKundeErstellen();
        }

        #endregion

        #region Produkt

        private void produktListBox_DoubleClick(object sender, EventArgs e)
        {
            Controller.ProduktGeklickt(produkteListBox.SelectedIndex);
        }

        private void produktListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Controller.ProduktGeklickt(produkteListBox.SelectedIndex);
        }


        private void produktNummerAufrufenButton_Click(object sender, EventArgs e)
        {
            Controller.ProduktMitNummerÖffnen((int) produktNummerAufrufenNumericUpDown.Value);
        }


        private void neuenProduktButton_Click(object sender, EventArgs e)
        {
            Controller.NeuenProduktErstellen();
        }

        #endregion

        #region Rezept

        private void rezeptListBox_DoubleClick(object sender, EventArgs e)
        {
            Controller.RezeptGeklickt(rezeptListBox.SelectedIndex);
        }

        private void rezeptListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Controller.ProduktGeklickt(rezeptListBox.SelectedIndex);
        }


        private void rezeptNummerAufrufenButton_Click(object sender, EventArgs e)
        {
            Controller.RezeptMitNummerÖffnen((int) rezeptNummerAufrufenNumericUpDown.Value);
        }


        private void neuesRezeptButton_Click(object sender, EventArgs e)
        {
            Controller.NeuenRezeptErstellen();
        }

        #endregion

        #region Lieferposition

        private void lieferungenListBox_DoubleClick(object sender, EventArgs e)
        {
            Controller.LieferungGeklickt(lieferungListBox.SelectedIndex);
        }

        private void lieferungenListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Controller.LieferungGeklickt(lieferungListBox.SelectedIndex);
        }


        private void lieferungNummerAufrufenButton_Click(object sender, EventArgs e)
        {
            Controller.LieferungMitNummerÖffnen((int) lieferpositionAufrufenNumericUpDown.Value);
        }


        private void neueLieferungButton_Click(object sender, EventArgs e)
        {
            Controller.NeueLieferungErstellen();
        }

        #endregion

        #region Bestellung

        private void bestellungenListBox_DoubleClick(object sender, EventArgs e)
        {
            Controller.BestellungGeklickt(bestellungenListBox.SelectedIndex);
        }

        private void bestellungenListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Controller.BestellungGeklickt(bestellungenListBox.SelectedIndex);
        }


        private void bestellungNummerAufrufenButton_Click(object sender, EventArgs e)
        {
            Controller.BestellungMitNummerÖffnen((int) bestellungAufrufenNumericUpDown.Value);
        }


        private void neueBestellungButton_Click(object sender, EventArgs e)
        {
            Controller.NeueBestellungErstellen();
        }

        #endregion

        #endregion
    }
}