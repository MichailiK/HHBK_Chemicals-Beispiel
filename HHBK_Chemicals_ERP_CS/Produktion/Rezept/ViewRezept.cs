using System;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <inheritdoc cref="IViewRezept" />
    public partial class ViewRezept : Form, IViewRezept
    {
        public ViewRezept()
        {
            InitializeComponent();
        }

        public IControllerRezept Controller { private get; set; }


        public int RezeptNummer
        {
            get => (int) rezeptNummerNumericUpDown.Value;
            set => rezeptNummerNumericUpDown.Value = value;
        }

        public int HerstellungsdauerMin
        {
            get => (int) verkaufseinheitNumericUpDown.Value;
            set => verkaufseinheitNumericUpDown.Value = value;
        }

        public int ArtikelNummer
        {
            get => (int) artikelNummerNumericUpDown.Value;
            set
            {
                artikelNummerNumericUpDown.Value = value;
                NameAktualisieren();
            }
        }


        /// <summary>
        ///     Aktualisiert den Namen in <see cref="Control.Text" /> und <see cref="rezeptNamenLabel" />
        /// </summary>
        /// <remarks>
        ///     Diese Methode wird durch das setzen von <see cref="ArtikelNummer" /> aufgerufen
        /// </remarks>
        private void NameAktualisieren()
        {
            var result = "Rezept für Artikel " + ArtikelNummer;
            rezeptNamenLabel.Text = result;
            Text = "Rezept - " + result;
        }

        #region Events

        private void ViewRezept_Load(object sender, EventArgs e)
        {
            Controller.FormGeladen();
        }


        private void artikelNummerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller.ProduktÖffnen(ArtikelNummer);
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.RezeptAktualisieren();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Rezeptdaten können nicht übernommen werden", MessageBoxButtons.OK,
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
                Controller.RezeptLöschen();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Rezeptdaten können nicht gelöscht werden", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}