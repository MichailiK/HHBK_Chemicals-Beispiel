using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS.Main
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

        #endregion
    }
}