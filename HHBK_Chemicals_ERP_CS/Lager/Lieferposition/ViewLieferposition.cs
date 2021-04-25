using System;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS.Lager.Lieferposition
{
    /// <inheritdoc cref="IViewLieferposition" />
    public partial class ViewLieferposition : Form, IViewLieferposition
    {
        public ViewLieferposition()
        {
            InitializeComponent();

            lieferdatumDateTimePicker.Value = DateTime.Now;
        }

        public IControllerLieferposition Controller { private get; set; }


        public int Id
        {
            get => (int) idNumericUpDown.Value;
            set => idNumericUpDown.Value = value;
        }

        public string Liefernummer
        {
            get => lieferNummerTextBox.Text;
            set
            {
                lieferNummerTextBox.Text = value;
                NameAktualisieren();
            }
        }

        public DateTimeOffset Versanddatum
        {
            get => new DateTimeOffset(versanddatumDateTimePicker.Value);
            set => versanddatumDateTimePicker.Value = value.LocalDateTime;
        }

        public DateTimeOffset? Lieferdatum
        {
            get => lieferdatumCheckBox.Checked ? new DateTimeOffset?(lieferdatumDateTimePicker.Value) : null;
            set
            {
                if (value.HasValue)
                {
                    lieferdatumCheckBox.Checked = true;
                    lieferdatumDateTimePicker.Value = value.Value.LocalDateTime;
                }
                else
                {
                    lieferdatumCheckBox.Checked = false;
                }
            }
        }

        public string NameVersandKontrolle
        {
            get => versandkontrolleTextBox.Text;
            set => versandkontrolleTextBox.Text = value;
        }

        public string NameSpedition
        {
            get => speditionTextBox.Text;
            set => speditionTextBox.Text = value;
        }

        /// <summary>
        ///     Aktualisiert den Namen in <see cref="Control.Text" /> und <see cref="lieferpositionNamenLabel" />
        /// </summary>
        /// <remarks>
        ///     Diese Methode wird durch das setzen von <see cref="Liefernummer" /> aufgerufen
        /// </remarks>
        private void NameAktualisieren()
        {
            lieferpositionNamenLabel.Text = Liefernummer;
            Text = "Lieferposition - " + Liefernummer;
        }

        #region Events

        private void lieferdatumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lieferdatumDateTimePicker.Enabled = lieferdatumCheckBox.Checked;
        }

        private void ViewLieferposition_Load(object sender, EventArgs e)
        {
            Controller.FormGeladen();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.LieferpositionAktualisieren();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Lieferposition-Daten können nicht übernommen werden",
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
                Controller.LieferpositionLöschen();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Lieferposition-Daten können nicht gelöscht werden", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}