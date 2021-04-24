using System;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS.Kunden
{
    /// <inheritdoc cref="IViewKunde" />
    public partial class ViewKunde : Form, IViewKunde
    {
        public IControllerKunde Controller { private get; set; }
        public ViewKunde()
        {
            InitializeComponent();
        }


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

        private void ViewKunde_Load(object sender, EventArgs e)
        {
            Controller.FormGeladen();
        }


        private void NameAktualisieren()
        {
            var result = string.IsNullOrWhiteSpace(Vorname) && string.IsNullOrWhiteSpace(Nachname)
                ? "<kein name>"
                : Vorname + " " + Nachname;
            kundenNameLabel.Text = result;
            Text = "Kunde - " + result;
        }
    }
}