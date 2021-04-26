using System.ComponentModel;

namespace HHBK_Chemicals_ERP_CS.Lager
{
    partial class ViewBestellposition
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
            System.Windows.Forms.Label d_bestellungNummerLabel;
            System.Windows.Forms.Label d_bestelldatumLabel;
            System.Windows.Forms.Label d_mengeLabel;
            this.d_bestellpositionsNummerLabel = new System.Windows.Forms.Label();
            this.bestellpositionNamenLabel = new System.Windows.Forms.Label();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.bestelldatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bestellungsnummerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mengeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kundenummerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lieferpositionsNummerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kundennummerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.lieferpositionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.produktnummerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.produktnummerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            d_bestellungNummerLabel = new System.Windows.Forms.Label();
            d_bestelldatumLabel = new System.Windows.Forms.Label();
            d_mengeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bestellungsnummerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.mengeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.kundenummerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.lieferpositionsNummerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.produktnummerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // d_bestellungNummerLabel
            // 
            d_bestellungNummerLabel.Location = new System.Drawing.Point(8, 71);
            d_bestellungNummerLabel.Name = "d_bestellungNummerLabel";
            d_bestellungNummerLabel.Size = new System.Drawing.Size(100, 20);
            d_bestellungNummerLabel.TabIndex = 5;
            d_bestellungNummerLabel.Text = "Bestellungsummer";
            // 
            // d_bestelldatumLabel
            // 
            d_bestelldatumLabel.Location = new System.Drawing.Point(8, 111);
            d_bestelldatumLabel.Name = "d_bestelldatumLabel";
            d_bestelldatumLabel.Size = new System.Drawing.Size(82, 20);
            d_bestelldatumLabel.TabIndex = 9;
            d_bestelldatumLabel.Text = "Bestelldatum";
            // 
            // d_mengeLabel
            // 
            d_mengeLabel.Location = new System.Drawing.Point(8, 91);
            d_mengeLabel.Name = "d_mengeLabel";
            d_mengeLabel.Size = new System.Drawing.Size(82, 20);
            d_mengeLabel.TabIndex = 7;
            d_mengeLabel.Text = "Menge";
            // 
            // d_bestellpositionsNummerLabel
            // 
            this.d_bestellpositionsNummerLabel.Location = new System.Drawing.Point(8, 32);
            this.d_bestellpositionsNummerLabel.Name = "d_bestellpositionsNummerLabel";
            this.d_bestellpositionsNummerLabel.Size = new System.Drawing.Size(121, 20);
            this.d_bestellpositionsNummerLabel.TabIndex = 1;
            this.d_bestellpositionsNummerLabel.Text = "Bestellpositionsnummer";
            // 
            // bestellpositionNamenLabel
            // 
            this.bestellpositionNamenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bestellpositionNamenLabel.Location = new System.Drawing.Point(0, 0);
            this.bestellpositionNamenLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bestellpositionNamenLabel.Name = "bestellpositionNamenLabel";
            this.bestellpositionNamenLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bestellpositionNamenLabel.Size = new System.Drawing.Size(304, 28);
            this.bestellpositionNamenLabel.TabIndex = 0;
            this.bestellpositionNamenLabel.Text = "Bestellpositionname";
            this.bestellpositionNamenLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.Enabled = false;
            this.idNumericUpDown.Location = new System.Drawing.Point(132, 30);
            this.idNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.idNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.ReadOnly = true;
            this.idNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.idNumericUpDown.TabIndex = 2;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(155, 181);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(141, 23);
            this.applyButton.TabIndex = 16;
            this.applyButton.Text = "OK";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(8, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(8, 210);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(288, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Bestellposition Löschen";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // bestelldatumDateTimePicker
            // 
            this.bestelldatumDateTimePicker.Location = new System.Drawing.Point(96, 109);
            this.bestelldatumDateTimePicker.Name = "bestelldatumDateTimePicker";
            this.bestelldatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.bestelldatumDateTimePicker.TabIndex = 10;
            this.bestelldatumDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // bestellungsnummerNumericUpDown
            // 
            this.bestellungsnummerNumericUpDown.Location = new System.Drawing.Point(132, 69);
            this.bestellungsnummerNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.bestellungsnummerNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.bestellungsnummerNumericUpDown.Name = "bestellungsnummerNumericUpDown";
            this.bestellungsnummerNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.bestellungsnummerNumericUpDown.TabIndex = 6;
            // 
            // mengeNumericUpDown
            // 
            this.mengeNumericUpDown.Location = new System.Drawing.Point(132, 89);
            this.mengeNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.mengeNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.mengeNumericUpDown.Name = "mengeNumericUpDown";
            this.mengeNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.mengeNumericUpDown.TabIndex = 8;
            // 
            // kundenummerNumericUpDown
            // 
            this.kundenummerNumericUpDown.Location = new System.Drawing.Point(132, 129);
            this.kundenummerNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.kundenummerNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.kundenummerNumericUpDown.Name = "kundenummerNumericUpDown";
            this.kundenummerNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.kundenummerNumericUpDown.TabIndex = 12;
            // 
            // lieferpositionsNummerNumericUpDown
            // 
            this.lieferpositionsNummerNumericUpDown.Location = new System.Drawing.Point(132, 149);
            this.lieferpositionsNummerNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.lieferpositionsNummerNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.lieferpositionsNummerNumericUpDown.Name = "lieferpositionsNummerNumericUpDown";
            this.lieferpositionsNummerNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.lieferpositionsNummerNumericUpDown.TabIndex = 14;
            // 
            // kundennummerLinkLabel
            // 
            this.kundennummerLinkLabel.Location = new System.Drawing.Point(8, 132);
            this.kundennummerLinkLabel.Name = "kundennummerLinkLabel";
            this.kundennummerLinkLabel.Size = new System.Drawing.Size(100, 20);
            this.kundennummerLinkLabel.TabIndex = 11;
            this.kundennummerLinkLabel.TabStop = true;
            this.kundennummerLinkLabel.Text = "Kundennummer";
            this.kundennummerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kundennummerLinkLabel_LinkClicked);
            // 
            // lieferpositionLinkLabel
            // 
            this.lieferpositionLinkLabel.Location = new System.Drawing.Point(8, 151);
            this.lieferpositionLinkLabel.Name = "lieferpositionLinkLabel";
            this.lieferpositionLinkLabel.Size = new System.Drawing.Size(121, 20);
            this.lieferpositionLinkLabel.TabIndex = 13;
            this.lieferpositionLinkLabel.TabStop = true;
            this.lieferpositionLinkLabel.Text = "Lieferpositionnummer";
            this.lieferpositionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lieferpositionLinkLabel_LinkClicked);
            // 
            // produktnummerLinkLabel
            // 
            this.produktnummerLinkLabel.Location = new System.Drawing.Point(8, 52);
            this.produktnummerLinkLabel.Name = "produktnummerLinkLabel";
            this.produktnummerLinkLabel.Size = new System.Drawing.Size(100, 20);
            this.produktnummerLinkLabel.TabIndex = 3;
            this.produktnummerLinkLabel.TabStop = true;
            this.produktnummerLinkLabel.Text = "Artikelnummer";
            this.produktnummerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.produktnummerLinkLabel_LinkClicked);
            // 
            // produktnummerNumericUpDown
            // 
            this.produktnummerNumericUpDown.Location = new System.Drawing.Point(132, 49);
            this.produktnummerNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.produktnummerNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.produktnummerNumericUpDown.Name = "produktnummerNumericUpDown";
            this.produktnummerNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.produktnummerNumericUpDown.TabIndex = 4;
            // 
            // ViewBestellposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(304, 239);
            this.Controls.Add(this.produktnummerLinkLabel);
            this.Controls.Add(this.produktnummerNumericUpDown);
            this.Controls.Add(this.lieferpositionLinkLabel);
            this.Controls.Add(this.kundennummerLinkLabel);
            this.Controls.Add(this.lieferpositionsNummerNumericUpDown);
            this.Controls.Add(this.kundenummerNumericUpDown);
            this.Controls.Add(this.mengeNumericUpDown);
            this.Controls.Add(d_mengeLabel);
            this.Controls.Add(this.bestellungsnummerNumericUpDown);
            this.Controls.Add(d_bestelldatumLabel);
            this.Controls.Add(this.bestelldatumDateTimePicker);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(d_bestellungNummerLabel);
            this.Controls.Add(this.d_bestellpositionsNummerLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.bestellpositionNamenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ViewBestellposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ViewBestellposition_Load);
            ((System.ComponentModel.ISupportInitialize) (this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bestellungsnummerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.mengeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.kundenummerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.lieferpositionsNummerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.produktnummerNumericUpDown)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label bestellpositionNamenLabel;

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.NumericUpDown idNumericUpDown;

        #endregion

        private System.Windows.Forms.Label d_bestellpositionsNummerLabel;
        private System.Windows.Forms.DateTimePicker bestelldatumDateTimePicker;
        private System.Windows.Forms.NumericUpDown bestellungsnummerNumericUpDown;
        private System.Windows.Forms.NumericUpDown mengeNumericUpDown;
        private System.Windows.Forms.NumericUpDown kundenummerNumericUpDown;
        private System.Windows.Forms.NumericUpDown lieferpositionsNummerNumericUpDown;
        private System.Windows.Forms.LinkLabel kundennummerLinkLabel;
        private System.Windows.Forms.LinkLabel lieferpositionLinkLabel;
        private System.Windows.Forms.LinkLabel produktnummerLinkLabel;
        private System.Windows.Forms.NumericUpDown produktnummerNumericUpDown;
    }
}