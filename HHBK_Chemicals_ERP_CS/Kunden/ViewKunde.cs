using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <inheritdoc cref="IViewKunde" />
    public partial class ViewKunde : Form, IViewKunde
    {
        public ViewKunde()
        {
            InitializeComponent();
        }

        public IControllerKunde Controller { private get; set; }


        public int Kundennummer
        {
            get => (int) kundennummerNumericUpDown.Value;
            set => kundennummerNumericUpDown.Value = value;
        }

        public string Vorname
        {
            get => vornameTextBox.Text;
            set
            {
                vornameTextBox.Text = value;
                NameAktualisieren();
            }
        }

        public string Nachname
        {
            get => nameTextBox.Text;
            set
            {
                nameTextBox.Text = value;
                NameAktualisieren();
            }
        }

        public string Strasse
        {
            get => strasseTextBox.Text;
            set => strasseTextBox.Text = value;
        }

        public int Hausnummer
        {
            get => (int) hausnummerNumericUpDown.Value;
            set => hausnummerNumericUpDown.Value = value;
        }

        public int Postleitzahl
        {
            get => (int) postleitzahlNumericUpDown.Value;
            set => postleitzahlNumericUpDown.Value = value;
        }

        public string Ort
        {
            get => ortTextBox.Text;
            set => ortTextBox.Text = value;
        }

        public string EmailAdresse
        {
            get => emailAdresseTextBox.Text;
            set => emailAdresseTextBox.Text = value;
        }


        /// <summary>
        ///     Aktualisiert den Namen in <see cref="Control.Text" /> und <see cref="kundenNameLabel" />
        /// </summary>
        /// <remarks>
        ///     Diese Methode wird durch das setzen von <see cref="Vorname" /> oder <see cref="Nachname" /> aufgerufen
        /// </remarks>
        private void NameAktualisieren()
        {
            var result = string.IsNullOrWhiteSpace(Vorname) && string.IsNullOrWhiteSpace(Nachname)
                ? "<kein name>"
                : Vorname + " " + Nachname;
            kundenNameLabel.Text = result;
            Text = "Kunde - " + result;
        }

        #region Events

        private void ViewKunde_Load(object sender, EventArgs e)
        {
            Controller.FormGeladen();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.KundeAktualisieren();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Kundendaten können nicht übernommen werden", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.KundeLöschen();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Kundendaten können nicht gelöscht werden", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #region Bestellung

        public void BestellungsListeAktualisieren(IEnumerable<string> namen)
        {
            bestellungListBox.Items.Clear();
            bestellungListBox.Items.AddRange(namen.Cast<object>().ToArray());
        }

        private void bestellungListBox_DoubleClick(object sender, EventArgs e)
        {
            Controller.BestellungGeklickt(bestellungListBox.SelectedIndex);
        }

        private void bestellungListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Controller.BestellungGeklickt(bestellungListBox.SelectedIndex);
        }

        private void bestellungsNummerAufrufenButton_Click(object sender, EventArgs e)
        {
            Controller.BestellungMitNummerÖffnen((int) bestellungsNummerAufrufenNumericUpDown.Value);
        }

        private void neueBestellungButton_Click(object sender, EventArgs e)
        {
            Controller.NeueBestellungErstellen();
        }

        #endregion

        #endregion
    }
}