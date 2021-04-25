using System;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS.Produktion
{
    /// <inheritdoc cref="IViewProdukt" />
    public partial class ViewProdukt : Form, IViewProdukt
    {
        public ViewProdukt()
        {
            InitializeComponent();
        }

        public IControllerProdukt Controller { private get; set; }


        public int Artikelnummer
        {
            get => (int) artikelNummerNumericUpDown.Value;
            set => artikelNummerNumericUpDown.Value = value;
        }

        public string ProduktName
        {
            get => nameTextBox.Text;
            set
            {
                nameTextBox.Text = value;
                NameAktualisieren();
            }
        }

        public int Verkaufseinheit
        {
            get => (int) verkaufseinheitNumericUpDown.Value;
            set => verkaufseinheitNumericUpDown.Value = value;
        }

        public string Einheit
        {
            get => einheitTextBox.Text;
            set => einheitTextBox.Text = value;
        }


        public decimal PreisVk
        {
            get => verkaufspreisNumericUpDown.Value;
            set => verkaufspreisNumericUpDown.Value = value;
        }


        /// <summary>
        ///     Aktualisiert den Namen in <see cref="Control.Text" /> und <see cref="produktNamenLabel" />
        /// </summary>
        /// <remarks>
        ///     Diese Methode wird durch das setzen von <see cref="ProduktName" /> aufgerufen
        /// </remarks>
        private void NameAktualisieren()
        {
            var result = string.IsNullOrWhiteSpace(ProduktName)
                ? "<kein name>"
                : ProduktName;
            produktNamenLabel.Text = result;
            Text = "Produkt - " + result;
        }

        #region Events

        private void ViewProdukt_Load(object sender, EventArgs e)
        {
            Controller.FormGeladen();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.ProduktAktualisieren();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Produktndaten können nicht übernommen werden", MessageBoxButtons.OK,
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
                Controller.ProduktLöschen();
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Produktndaten können nicht gelöscht werden", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}