using System.ComponentModel;

namespace HHBK_Chemicals_ERP_CS.Produktion
{
    partial class ViewProdukt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label d_nameLabel;
            System.Windows.Forms.Label d_verkaufseinheitLabel;
            System.Windows.Forms.Label d_verkaufsPreisLabel;
            System.Windows.Forms.Label d_einheitLabel;
            System.Windows.Forms.Label d_artikelNummerLabel;
            this.produktNamenLabel = new System.Windows.Forms.Label();
            this.artikelNummerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.verkaufseinheitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.verkaufspreisNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.einheitTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            d_nameLabel = new System.Windows.Forms.Label();
            d_verkaufseinheitLabel = new System.Windows.Forms.Label();
            d_verkaufsPreisLabel = new System.Windows.Forms.Label();
            d_einheitLabel = new System.Windows.Forms.Label();
            d_artikelNummerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.artikelNummerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.verkaufseinheitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.verkaufspreisNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // d_nameLabel
            // 
            d_nameLabel.Location = new System.Drawing.Point(8, 56);
            d_nameLabel.Name = "d_nameLabel";
            d_nameLabel.Size = new System.Drawing.Size(100, 20);
            d_nameLabel.TabIndex = 3;
            d_nameLabel.Text = "Name";
            // 
            // d_verkaufseinheitLabel
            // 
            d_verkaufseinheitLabel.Location = new System.Drawing.Point(8, 78);
            d_verkaufseinheitLabel.Name = "d_verkaufseinheitLabel";
            d_verkaufseinheitLabel.Size = new System.Drawing.Size(100, 20);
            d_verkaufseinheitLabel.TabIndex = 9;
            d_verkaufseinheitLabel.Text = "Verkaufseinheit";
            // 
            // d_verkaufsPreisLabel
            // 
            d_verkaufsPreisLabel.Location = new System.Drawing.Point(8, 125);
            d_verkaufsPreisLabel.Name = "d_verkaufsPreisLabel";
            d_verkaufsPreisLabel.Size = new System.Drawing.Size(100, 20);
            d_verkaufsPreisLabel.TabIndex = 11;
            d_verkaufsPreisLabel.Text = "Verkaufspreis";
            // 
            // d_einheitLabel
            // 
            d_einheitLabel.Location = new System.Drawing.Point(8, 102);
            d_einheitLabel.Name = "d_einheitLabel";
            d_einheitLabel.Size = new System.Drawing.Size(100, 20);
            d_einheitLabel.TabIndex = 13;
            d_einheitLabel.Text = "Einheit";
            // 
            // d_artikelNummerLabel
            // 
            d_artikelNummerLabel.Location = new System.Drawing.Point(8, 32);
            d_artikelNummerLabel.Name = "d_artikelNummerLabel";
            d_artikelNummerLabel.Size = new System.Drawing.Size(100, 20);
            d_artikelNummerLabel.TabIndex = 1;
            d_artikelNummerLabel.Text = "Artikelnummer";
            // 
            // produktNamenLabel
            // 
            this.produktNamenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.produktNamenLabel.Location = new System.Drawing.Point(0, 0);
            this.produktNamenLabel.Margin = new System.Windows.Forms.Padding(0);
            this.produktNamenLabel.Name = "produktNamenLabel";
            this.produktNamenLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.produktNamenLabel.Size = new System.Drawing.Size(304, 28);
            this.produktNamenLabel.TabIndex = 0;
            this.produktNamenLabel.Text = "Produktname";
            this.produktNamenLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // artikelNummerNumericUpDown
            // 
            this.artikelNummerNumericUpDown.Enabled = false;
            this.artikelNummerNumericUpDown.Location = new System.Drawing.Point(132, 30);
            this.artikelNummerNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.artikelNummerNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.artikelNummerNumericUpDown.Name = "artikelNummerNumericUpDown";
            this.artikelNummerNumericUpDown.ReadOnly = true;
            this.artikelNummerNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.artikelNummerNumericUpDown.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 53);
            this.nameTextBox.MaxLength = 45;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // verkaufseinheitNumericUpDown
            // 
            this.verkaufseinheitNumericUpDown.Location = new System.Drawing.Point(132, 76);
            this.verkaufseinheitNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.verkaufseinheitNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.verkaufseinheitNumericUpDown.Name = "verkaufseinheitNumericUpDown";
            this.verkaufseinheitNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.verkaufseinheitNumericUpDown.TabIndex = 10;
            // 
            // verkaufspreisNumericUpDown
            // 
            this.verkaufspreisNumericUpDown.DecimalPlaces = 2;
            this.verkaufspreisNumericUpDown.Location = new System.Drawing.Point(132, 125);
            this.verkaufspreisNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.verkaufspreisNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.verkaufspreisNumericUpDown.Name = "verkaufspreisNumericUpDown";
            this.verkaufspreisNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.verkaufspreisNumericUpDown.TabIndex = 12;
            // 
            // einheitTextBox
            // 
            this.einheitTextBox.Location = new System.Drawing.Point(132, 99);
            this.einheitTextBox.MaxLength = 45;
            this.einheitTextBox.Name = "einheitTextBox";
            this.einheitTextBox.Size = new System.Drawing.Size(164, 20);
            this.einheitTextBox.TabIndex = 14;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(155, 148);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(141, 23);
            this.applyButton.TabIndex = 18;
            this.applyButton.Text = "OK";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(8, 148);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(8, 177);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(288, 23);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Produkt Löschen";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ViewProdukt
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 207);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(d_einheitLabel);
            this.Controls.Add(this.einheitTextBox);
            this.Controls.Add(d_verkaufsPreisLabel);
            this.Controls.Add(this.verkaufspreisNumericUpDown);
            this.Controls.Add(this.verkaufseinheitNumericUpDown);
            this.Controls.Add(d_verkaufseinheitLabel);
            this.Controls.Add(d_nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(d_artikelNummerLabel);
            this.Controls.Add(this.artikelNummerNumericUpDown);
            this.Controls.Add(this.produktNamenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produkt - Produktnname";
            this.Load += new System.EventHandler(this.ViewProdukt_Load);
            ((System.ComponentModel.ISupportInitialize) (this.artikelNummerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.verkaufseinheitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.verkaufspreisNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox einheitTextBox;

        private System.Windows.Forms.Label produktNamenLabel;

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.NumericUpDown verkaufspreisNumericUpDown;

        private System.Windows.Forms.NumericUpDown verkaufseinheitNumericUpDown;

        private System.Windows.Forms.TextBox nameTextBox;

        private System.Windows.Forms.NumericUpDown artikelNummerNumericUpDown;

        #endregion
    }
}