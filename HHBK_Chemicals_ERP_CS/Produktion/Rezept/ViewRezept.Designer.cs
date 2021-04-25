using System.ComponentModel;

namespace HHBK_Chemicals_ERP_CS.Produktion
{
    partial class ViewRezept
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
            System.Windows.Forms.Label d_herstellungsdauerLabel;
            System.Windows.Forms.Label d_artikelNummerLabel;
            System.Windows.Forms.Label d_rezeptNummerLabel;
            this.rezeptNamenLabel = new System.Windows.Forms.Label();
            this.rezeptNummerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.verkaufseinheitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.artikelNummerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.d_minutenLabel = new System.Windows.Forms.Label();
            d_herstellungsdauerLabel = new System.Windows.Forms.Label();
            d_artikelNummerLabel = new System.Windows.Forms.Label();
            d_rezeptNummerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rezeptNummerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verkaufseinheitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelNummerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // d_herstellungsdauerLabel
            // 
            d_herstellungsdauerLabel.Location = new System.Drawing.Point(8, 54);
            d_herstellungsdauerLabel.Name = "d_herstellungsdauerLabel";
            d_herstellungsdauerLabel.Size = new System.Drawing.Size(100, 20);
            d_herstellungsdauerLabel.TabIndex = 3;
            d_herstellungsdauerLabel.Text = "Herstellungsdauer";
            // 
            // d_artikelNummerLabel
            // 
            d_artikelNummerLabel.Location = new System.Drawing.Point(8, 74);
            d_artikelNummerLabel.Name = "d_artikelNummerLabel";
            d_artikelNummerLabel.Size = new System.Drawing.Size(100, 20);
            d_artikelNummerLabel.TabIndex = 6;
            d_artikelNummerLabel.Text = "Artikelnummer";
            // 
            // d_rezeptNummerLabel
            // 
            d_rezeptNummerLabel.Location = new System.Drawing.Point(8, 32);
            d_rezeptNummerLabel.Name = "d_rezeptNummerLabel";
            d_rezeptNummerLabel.Size = new System.Drawing.Size(100, 20);
            d_rezeptNummerLabel.TabIndex = 1;
            d_rezeptNummerLabel.Text = "Rezeptnummer";
            // 
            // rezeptNamenLabel
            // 
            this.rezeptNamenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezeptNamenLabel.Location = new System.Drawing.Point(0, 0);
            this.rezeptNamenLabel.Margin = new System.Windows.Forms.Padding(0);
            this.rezeptNamenLabel.Name = "rezeptNamenLabel";
            this.rezeptNamenLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rezeptNamenLabel.Size = new System.Drawing.Size(304, 28);
            this.rezeptNamenLabel.TabIndex = 0;
            this.rezeptNamenLabel.Text = "Rezeptname";
            this.rezeptNamenLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rezeptNummerNumericUpDown
            // 
            this.rezeptNummerNumericUpDown.Enabled = false;
            this.rezeptNummerNumericUpDown.Location = new System.Drawing.Point(132, 30);
            this.rezeptNummerNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.rezeptNummerNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.rezeptNummerNumericUpDown.Name = "rezeptNummerNumericUpDown";
            this.rezeptNummerNumericUpDown.ReadOnly = true;
            this.rezeptNummerNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.rezeptNummerNumericUpDown.TabIndex = 2;
            // 
            // verkaufseinheitNumericUpDown
            // 
            this.verkaufseinheitNumericUpDown.Location = new System.Drawing.Point(132, 52);
            this.verkaufseinheitNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.verkaufseinheitNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.verkaufseinheitNumericUpDown.Name = "verkaufseinheitNumericUpDown";
            this.verkaufseinheitNumericUpDown.Size = new System.Drawing.Size(116, 20);
            this.verkaufseinheitNumericUpDown.TabIndex = 4;
            // 
            // artikelNummerNumericUpDown
            // 
            this.artikelNummerNumericUpDown.Location = new System.Drawing.Point(132, 74);
            this.artikelNummerNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.artikelNummerNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.artikelNummerNumericUpDown.Name = "artikelNummerNumericUpDown";
            this.artikelNummerNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.artikelNummerNumericUpDown.TabIndex = 7;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(155, 106);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(141, 23);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "OK";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(8, 106);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(8, 135);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(288, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Rezept Löschen";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // d_minutenLabel
            // 
            this.d_minutenLabel.Location = new System.Drawing.Point(251, 51);
            this.d_minutenLabel.Name = "d_minutenLabel";
            this.d_minutenLabel.Size = new System.Drawing.Size(45, 23);
            this.d_minutenLabel.TabIndex = 5;
            this.d_minutenLabel.Text = "Minuten";
            this.d_minutenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewRezept
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 163);
            this.Controls.Add(this.d_minutenLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(d_artikelNummerLabel);
            this.Controls.Add(this.artikelNummerNumericUpDown);
            this.Controls.Add(this.verkaufseinheitNumericUpDown);
            this.Controls.Add(d_herstellungsdauerLabel);
            this.Controls.Add(d_rezeptNummerLabel);
            this.Controls.Add(this.rezeptNummerNumericUpDown);
            this.Controls.Add(this.rezeptNamenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewRezept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rezept - Rezeptnname";
            this.Load += new System.EventHandler(this.ViewRezept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezeptNummerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verkaufseinheitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelNummerNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label d_minutenLabel;

        private System.Windows.Forms.Label rezeptNamenLabel;

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.NumericUpDown rezeptNummerNumericUpDown;

        private System.Windows.Forms.NumericUpDown verkaufseinheitNumericUpDown;

        private System.Windows.Forms.NumericUpDown artikelNummerNumericUpDown;

        #endregion
    }
}