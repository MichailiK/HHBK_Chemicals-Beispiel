using System;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS.Lager
{
    /// <inheritdoc cref="IViewBestellposition" />
    public partial class ViewBestellposition : Form, IViewBestellposition
    {
        public ViewBestellposition()
        {
            InitializeComponent();

            bestelldatumDateTimePicker.Value = DateTime.Now;
        }

        public IControllerBestellposition Controller { private get; set; }


        public int Bestellpositionsnummer
        {
            get => (int) idNumericUpDown.Value;
            set => idNumericUpDown.Value = value;
        }

        public int Bestellungsnummer
        {
            get => (int) bestellungsnummerNumericUpDown.Value;
            set
            {
                bestellungsnummerNumericUpDown.Value = value;
                NameAktualisieren();
            }
        }

        public int ArtikelNummer
        {
            get => (int) produktnummerNumericUpDown.Value;
            set => produktnummerNumericUpDown.Value = value;
        }

        public int Menge
        {
            get => (int) mengeNumericUpDown.Value;
            set => mengeNumericUpDown.Value = value;
        }

        public DateTimeOffset Bestelldatum
        {
            get => new DateTimeOffset(bestelldatumDateTimePicker.Value);
            set => bestelldatumDateTimePicker.Value = value.LocalDateTime;
        }

        public int Kundennummer
        {
            get => (int) kundenummerNumericUpDown.Value;
            set => kundenummerNumericUpDown.Value = value;
        }

        public int LieferpositionId
        {
            get => (int) lieferpositionsNummerNumericUpDown.Value;
            set => lieferpositionsNummerNumericUpDown.Value = value;
        }

        /// <summary>
        ///     Aktualisiert den Namen in <see cref="Control.Text" /> und <see cref="bestellpositionNamenLabel" />
        /// </summary>
        /// <remarks>
        ///     Diese Methode wird durch das setzen von <see cref="Bestellungsnummer" /> aufgerufen
        /// </remarks>
        private void NameAktualisieren()
        {
            bestellpositionNamenLabel.Text = Bestellungsnummer.ToString();
            Text = "Bestellposition - " + Bestellungsnummer;
        }

        #region Events

        private void ViewBestellposition_Load(object sender, EventArgs e)
        {
            Controller.FormGeladen();
        }


        private void produktnummerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller.ProduktÖffnen(ArtikelNummer);
        }

        private void kundennummerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller.KundeÖffnen(Kundennummer);
        }

        private void lieferpositionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller.LieferpositionÖffnen(LieferpositionId);
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.BestellpositionAktualisieren();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Bestellposition-Daten können nicht übernommen werden",
                    MessageBoxButtons.OK,
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
                Controller.BestellpositionLöschen();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Bestellposition-Daten können nicht gelöscht werden", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}