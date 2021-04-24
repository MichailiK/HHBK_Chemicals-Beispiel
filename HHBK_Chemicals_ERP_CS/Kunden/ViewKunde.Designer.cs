using System.ComponentModel;

namespace HHBK_Chemicals_ERP_CS.Kunden
{
    partial class ViewKunde
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
            System.Windows.Forms.Label d_kundenNummerLabel;
            System.Windows.Forms.Label d_nameLabel;
            System.Windows.Forms.Label d_vornameLabel;
            System.Windows.Forms.Label d_strasseLabel;
            System.Windows.Forms.Label d_hausnummerLabel;
            System.Windows.Forms.Label d_postleitzahlLabel;
            System.Windows.Forms.Label d_ortLabel;
            System.Windows.Forms.Label d_emailAdresseLabel;
            this.kundenNameLabel = new System.Windows.Forms.Label();
            this.kundennummerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.strasseTextBox = new System.Windows.Forms.TextBox();
            this.hausnummerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.postleitzahlNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ortTextBox = new System.Windows.Forms.TextBox();
            this.emailAdresseTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            d_kundenNummerLabel = new System.Windows.Forms.Label();
            d_nameLabel = new System.Windows.Forms.Label();
            d_vornameLabel = new System.Windows.Forms.Label();
            d_strasseLabel = new System.Windows.Forms.Label();
            d_hausnummerLabel = new System.Windows.Forms.Label();
            d_postleitzahlLabel = new System.Windows.Forms.Label();
            d_ortLabel = new System.Windows.Forms.Label();
            d_emailAdresseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.kundennummerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.hausnummerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.postleitzahlNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // d_kundenNummerLabel
            // 
            d_kundenNummerLabel.Location = new System.Drawing.Point(8, 32);
            d_kundenNummerLabel.Name = "d_kundenNummerLabel";
            d_kundenNummerLabel.Size = new System.Drawing.Size(100, 20);
            d_kundenNummerLabel.TabIndex = 1;
            d_kundenNummerLabel.Text = "Kundennummer";
            // 
            // d_nameLabel
            // 
            d_nameLabel.Location = new System.Drawing.Point(8, 56);
            d_nameLabel.Name = "d_nameLabel";
            d_nameLabel.Size = new System.Drawing.Size(100, 20);
            d_nameLabel.TabIndex = 3;
            d_nameLabel.Text = "Name";
            // 
            // d_vornameLabel
            // 
            d_vornameLabel.Location = new System.Drawing.Point(8, 82);
            d_vornameLabel.Name = "d_vornameLabel";
            d_vornameLabel.Size = new System.Drawing.Size(100, 20);
            d_vornameLabel.TabIndex = 5;
            d_vornameLabel.Text = "Vorname";
            // 
            // d_strasseLabel
            // 
            d_strasseLabel.Location = new System.Drawing.Point(8, 108);
            d_strasseLabel.Name = "d_strasseLabel";
            d_strasseLabel.Size = new System.Drawing.Size(100, 20);
            d_strasseLabel.TabIndex = 7;
            d_strasseLabel.Text = "Strasse";
            // 
            // d_hausnummerLabel
            // 
            d_hausnummerLabel.Location = new System.Drawing.Point(8, 130);
            d_hausnummerLabel.Name = "d_hausnummerLabel";
            d_hausnummerLabel.Size = new System.Drawing.Size(100, 20);
            d_hausnummerLabel.TabIndex = 9;
            d_hausnummerLabel.Text = "Hausnummer";
            // 
            // d_postleitzahlLabel
            // 
            d_postleitzahlLabel.Location = new System.Drawing.Point(8, 154);
            d_postleitzahlLabel.Name = "d_postleitzahlLabel";
            d_postleitzahlLabel.Size = new System.Drawing.Size(100, 20);
            d_postleitzahlLabel.TabIndex = 11;
            d_postleitzahlLabel.Text = "Postleitzahl";
            // 
            // d_ortLabel
            // 
            d_ortLabel.Location = new System.Drawing.Point(8, 178);
            d_ortLabel.Name = "d_ortLabel";
            d_ortLabel.Size = new System.Drawing.Size(100, 20);
            d_ortLabel.TabIndex = 13;
            d_ortLabel.Text = "Ort";
            // 
            // d_emailAdresseLabel
            // 
            d_emailAdresseLabel.Location = new System.Drawing.Point(8, 201);
            d_emailAdresseLabel.Name = "d_emailAdresseLabel";
            d_emailAdresseLabel.Size = new System.Drawing.Size(100, 20);
            d_emailAdresseLabel.TabIndex = 15;
            d_emailAdresseLabel.Text = "Email Adresse";
            // 
            // kundenNameLabel
            // 
            this.kundenNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.kundenNameLabel.Location = new System.Drawing.Point(0, 0);
            this.kundenNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.kundenNameLabel.Name = "kundenNameLabel";
            this.kundenNameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.kundenNameLabel.Size = new System.Drawing.Size(304, 28);
            this.kundenNameLabel.TabIndex = 0;
            this.kundenNameLabel.Text = "Kundenname";
            this.kundenNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kundennummerNumericUpDown
            // 
            this.kundennummerNumericUpDown.Enabled = false;
            this.kundennummerNumericUpDown.Location = new System.Drawing.Point(132, 30);
            this.kundennummerNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.kundennummerNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.kundennummerNumericUpDown.Name = "kundennummerNumericUpDown";
            this.kundennummerNumericUpDown.ReadOnly = true;
            this.kundennummerNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.kundennummerNumericUpDown.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 53);
            this.nameTextBox.MaxLength = 45;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.Location = new System.Drawing.Point(132, 79);
            this.vornameTextBox.MaxLength = 45;
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(164, 20);
            this.vornameTextBox.TabIndex = 6;
            // 
            // strasseTextBox
            // 
            this.strasseTextBox.Location = new System.Drawing.Point(132, 105);
            this.strasseTextBox.MaxLength = 45;
            this.strasseTextBox.Name = "strasseTextBox";
            this.strasseTextBox.Size = new System.Drawing.Size(164, 20);
            this.strasseTextBox.TabIndex = 8;
            // 
            // hausnummerNumericUpDown
            // 
            this.hausnummerNumericUpDown.Location = new System.Drawing.Point(132, 128);
            this.hausnummerNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.hausnummerNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.hausnummerNumericUpDown.Name = "hausnummerNumericUpDown";
            this.hausnummerNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.hausnummerNumericUpDown.TabIndex = 10;
            // 
            // postleitzahlNumericUpDown
            // 
            this.postleitzahlNumericUpDown.Location = new System.Drawing.Point(132, 152);
            this.postleitzahlNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.postleitzahlNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.postleitzahlNumericUpDown.Name = "postleitzahlNumericUpDown";
            this.postleitzahlNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.postleitzahlNumericUpDown.TabIndex = 12;
            // 
            // ortTextBox
            // 
            this.ortTextBox.Location = new System.Drawing.Point(132, 175);
            this.ortTextBox.MaxLength = 45;
            this.ortTextBox.Name = "ortTextBox";
            this.ortTextBox.Size = new System.Drawing.Size(164, 20);
            this.ortTextBox.TabIndex = 14;
            // 
            // emailAdresseTextBox
            // 
            this.emailAdresseTextBox.Location = new System.Drawing.Point(132, 198);
            this.emailAdresseTextBox.MaxLength = 45;
            this.emailAdresseTextBox.Name = "emailAdresseTextBox";
            this.emailAdresseTextBox.Size = new System.Drawing.Size(164, 20);
            this.emailAdresseTextBox.TabIndex = 16;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(155, 224);
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
            this.cancelButton.Location = new System.Drawing.Point(8, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(8, 254);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(288, 23);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Kunde Löschen";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ViewKunde
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 282);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.emailAdresseTextBox);
            this.Controls.Add(d_emailAdresseLabel);
            this.Controls.Add(d_ortLabel);
            this.Controls.Add(this.ortTextBox);
            this.Controls.Add(d_postleitzahlLabel);
            this.Controls.Add(this.postleitzahlNumericUpDown);
            this.Controls.Add(this.hausnummerNumericUpDown);
            this.Controls.Add(d_hausnummerLabel);
            this.Controls.Add(this.strasseTextBox);
            this.Controls.Add(d_strasseLabel);
            this.Controls.Add(d_vornameLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(d_nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(d_kundenNummerLabel);
            this.Controls.Add(this.kundennummerNumericUpDown);
            this.Controls.Add(this.kundenNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewKunde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kunde - Kundenname";
            this.Load += new System.EventHandler(this.ViewKunde_Load);
            ((System.ComponentModel.ISupportInitialize) (this.kundennummerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.hausnummerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.postleitzahlNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox emailAdresseTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.NumericUpDown postleitzahlNumericUpDown;
        private System.Windows.Forms.TextBox ortTextBox;

        private System.Windows.Forms.TextBox strasseTextBox;
        private System.Windows.Forms.NumericUpDown hausnummerNumericUpDown;

        private System.Windows.Forms.TextBox vornameTextBox;

        private System.Windows.Forms.TextBox nameTextBox;

        private System.Windows.Forms.NumericUpDown kundennummerNumericUpDown;


        private System.Windows.Forms.Label kundenNameLabel;

        #endregion
    }
}