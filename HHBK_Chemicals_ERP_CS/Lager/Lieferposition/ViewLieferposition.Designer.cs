using System.ComponentModel;

namespace HHBK_Chemicals_ERP_CS.Lager.Lieferposition
{
    partial class ViewLieferposition
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
            System.Windows.Forms.Label d_lieferNummerLabel;
            System.Windows.Forms.Label d_lieferDatumLabel;
            System.Windows.Forms.Label d_versanddatumLabel;
            System.Windows.Forms.Label d_versandkontrolleLabel;
            System.Windows.Forms.Label d_speditionLabel;
            this.d_idLabel = new System.Windows.Forms.Label();
            this.lieferpositionNamenLabel = new System.Windows.Forms.Label();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.lieferNummerTextBox = new System.Windows.Forms.TextBox();
            this.versanddatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lieferdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lieferdatumCheckBox = new System.Windows.Forms.CheckBox();
            this.versandkontrolleTextBox = new System.Windows.Forms.TextBox();
            this.speditionTextBox = new System.Windows.Forms.TextBox();
            d_lieferNummerLabel = new System.Windows.Forms.Label();
            d_lieferDatumLabel = new System.Windows.Forms.Label();
            d_versanddatumLabel = new System.Windows.Forms.Label();
            d_versandkontrolleLabel = new System.Windows.Forms.Label();
            d_speditionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.idNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // d_lieferNummerLabel
            // 
            d_lieferNummerLabel.Location = new System.Drawing.Point(8, 56);
            d_lieferNummerLabel.Name = "d_lieferNummerLabel";
            d_lieferNummerLabel.Size = new System.Drawing.Size(100, 20);
            d_lieferNummerLabel.TabIndex = 3;
            d_lieferNummerLabel.Text = "Liefernummer";
            // 
            // d_lieferDatumLabel
            // 
            d_lieferDatumLabel.Location = new System.Drawing.Point(8, 107);
            d_lieferDatumLabel.Name = "d_lieferDatumLabel";
            d_lieferDatumLabel.Size = new System.Drawing.Size(82, 20);
            d_lieferDatumLabel.TabIndex = 7;
            d_lieferDatumLabel.Text = "Lieferdatum";
            // 
            // d_versanddatumLabel
            // 
            d_versanddatumLabel.Location = new System.Drawing.Point(8, 79);
            d_versanddatumLabel.Name = "d_versanddatumLabel";
            d_versanddatumLabel.Size = new System.Drawing.Size(82, 20);
            d_versanddatumLabel.TabIndex = 5;
            d_versanddatumLabel.Text = "Versanddatum";
            // 
            // d_versandkontrolleLabel
            // 
            d_versandkontrolleLabel.Location = new System.Drawing.Point(8, 134);
            d_versandkontrolleLabel.Name = "d_versandkontrolleLabel";
            d_versandkontrolleLabel.Size = new System.Drawing.Size(100, 20);
            d_versandkontrolleLabel.TabIndex = 10;
            d_versandkontrolleLabel.Text = "Versandkontrolle";
            // 
            // d_speditionLabel
            // 
            d_speditionLabel.Location = new System.Drawing.Point(8, 160);
            d_speditionLabel.Name = "d_speditionLabel";
            d_speditionLabel.Size = new System.Drawing.Size(100, 20);
            d_speditionLabel.TabIndex = 13;
            d_speditionLabel.Text = "Spedition";
            // 
            // d_idLabel
            // 
            this.d_idLabel.Location = new System.Drawing.Point(8, 32);
            this.d_idLabel.Name = "d_idLabel";
            this.d_idLabel.Size = new System.Drawing.Size(100, 20);
            this.d_idLabel.TabIndex = 1;
            this.d_idLabel.Text = "ID";
            // 
            // lieferpositionNamenLabel
            // 
            this.lieferpositionNamenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lieferpositionNamenLabel.Location = new System.Drawing.Point(0, 0);
            this.lieferpositionNamenLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lieferpositionNamenLabel.Name = "lieferpositionNamenLabel";
            this.lieferpositionNamenLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lieferpositionNamenLabel.Size = new System.Drawing.Size(304, 28);
            this.lieferpositionNamenLabel.TabIndex = 0;
            this.lieferpositionNamenLabel.Text = "Lieferpositionname";
            this.lieferpositionNamenLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.applyButton.Location = new System.Drawing.Point(155, 192);
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
            this.cancelButton.Location = new System.Drawing.Point(8, 192);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(8, 221);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(288, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Lieferposition Löschen";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // lieferNummerTextBox
            // 
            this.lieferNummerTextBox.Location = new System.Drawing.Point(132, 53);
            this.lieferNummerTextBox.MaxLength = 45;
            this.lieferNummerTextBox.Name = "lieferNummerTextBox";
            this.lieferNummerTextBox.Size = new System.Drawing.Size(164, 20);
            this.lieferNummerTextBox.TabIndex = 4;
            // 
            // versanddatumDateTimePicker
            // 
            this.versanddatumDateTimePicker.Location = new System.Drawing.Point(96, 79);
            this.versanddatumDateTimePicker.Name = "versanddatumDateTimePicker";
            this.versanddatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.versanddatumDateTimePicker.TabIndex = 6;
            this.versanddatumDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lieferdatumDateTimePicker
            // 
            this.lieferdatumDateTimePicker.Enabled = false;
            this.lieferdatumDateTimePicker.Location = new System.Drawing.Point(96, 105);
            this.lieferdatumDateTimePicker.Name = "lieferdatumDateTimePicker";
            this.lieferdatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lieferdatumDateTimePicker.TabIndex = 9;
            this.lieferdatumDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lieferdatumCheckBox
            // 
            this.lieferdatumCheckBox.AutoSize = true;
            this.lieferdatumCheckBox.Location = new System.Drawing.Point(75, 108);
            this.lieferdatumCheckBox.Name = "lieferdatumCheckBox";
            this.lieferdatumCheckBox.Size = new System.Drawing.Size(15, 14);
            this.lieferdatumCheckBox.TabIndex = 8;
            this.lieferdatumCheckBox.UseVisualStyleBackColor = true;
            this.lieferdatumCheckBox.CheckedChanged += new System.EventHandler(this.lieferdatumCheckBox_CheckedChanged);
            // 
            // versandkontrolleTextBox
            // 
            this.versandkontrolleTextBox.Location = new System.Drawing.Point(132, 131);
            this.versandkontrolleTextBox.MaxLength = 45;
            this.versandkontrolleTextBox.Name = "versandkontrolleTextBox";
            this.versandkontrolleTextBox.Size = new System.Drawing.Size(164, 20);
            this.versandkontrolleTextBox.TabIndex = 11;
            // 
            // speditionTextBox
            // 
            this.speditionTextBox.Location = new System.Drawing.Point(132, 157);
            this.speditionTextBox.MaxLength = 45;
            this.speditionTextBox.Name = "speditionTextBox";
            this.speditionTextBox.Size = new System.Drawing.Size(164, 20);
            this.speditionTextBox.TabIndex = 14;
            // 
            // ViewLieferposition
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 251);
            this.Controls.Add(this.speditionTextBox);
            this.Controls.Add(d_speditionLabel);
            this.Controls.Add(this.versandkontrolleTextBox);
            this.Controls.Add(d_versandkontrolleLabel);
            this.Controls.Add(this.lieferdatumCheckBox);
            this.Controls.Add(this.lieferdatumDateTimePicker);
            this.Controls.Add(d_versanddatumLabel);
            this.Controls.Add(this.versanddatumDateTimePicker);
            this.Controls.Add(this.lieferNummerTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(d_lieferDatumLabel);
            this.Controls.Add(d_lieferNummerLabel);
            this.Controls.Add(this.d_idLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.lieferpositionNamenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewLieferposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lieferposition - Lieferpositionnname";
            this.Load += new System.EventHandler(this.ViewLieferposition_Load);
            ((System.ComponentModel.ISupportInitialize) (this.idNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lieferpositionNamenLabel;

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.NumericUpDown idNumericUpDown;

        #endregion

        private System.Windows.Forms.Label d_idLabel;
        private System.Windows.Forms.TextBox lieferNummerTextBox;
        private System.Windows.Forms.DateTimePicker versanddatumDateTimePicker;
        private System.Windows.Forms.DateTimePicker lieferdatumDateTimePicker;
        private System.Windows.Forms.CheckBox lieferdatumCheckBox;
        private System.Windows.Forms.TextBox versandkontrolleTextBox;
        private System.Windows.Forms.TextBox speditionTextBox;
    }
}