namespace HHBK_Chemicals_ERP_CS.Main
{
    partial class ViewMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Label d_kundenAufrufenLabel;
            this.kundeGroupBox = new System.Windows.Forms.GroupBox();
            this.neuenKundeButton = new System.Windows.Forms.Button();
            this.kundeNummerAufrufenButton = new System.Windows.Forms.Button();
            this.kundenNummerAufrufenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kundenListBox = new System.Windows.Forms.ListBox();
            d_kundenAufrufenLabel = new System.Windows.Forms.Label();
            this.kundeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.kundenNummerAufrufenNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // d_kundenAufrufenLabel
            // 
            d_kundenAufrufenLabel.Location = new System.Drawing.Point(6, 512);
            d_kundenAufrufenLabel.Name = "d_kundenAufrufenLabel";
            d_kundenAufrufenLabel.Size = new System.Drawing.Size(188, 21);
            d_kundenAufrufenLabel.TabIndex = 2;
            d_kundenAufrufenLabel.Text = "Kundennummer aufrufen";
            // 
            // kundeGroupBox
            // 
            this.kundeGroupBox.Controls.Add(this.neuenKundeButton);
            this.kundeGroupBox.Controls.Add(this.kundeNummerAufrufenButton);
            this.kundeGroupBox.Controls.Add(d_kundenAufrufenLabel);
            this.kundeGroupBox.Controls.Add(this.kundenNummerAufrufenNumericUpDown);
            this.kundeGroupBox.Controls.Add(this.kundenListBox);
            this.kundeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.kundeGroupBox.Name = "kundeGroupBox";
            this.kundeGroupBox.Size = new System.Drawing.Size(200, 570);
            this.kundeGroupBox.TabIndex = 0;
            this.kundeGroupBox.TabStop = false;
            this.kundeGroupBox.Text = "Kunden";
            // 
            // neuenKundeButton
            // 
            this.neuenKundeButton.Location = new System.Drawing.Point(6, 471);
            this.neuenKundeButton.Name = "neuenKundeButton";
            this.neuenKundeButton.Size = new System.Drawing.Size(188, 23);
            this.neuenKundeButton.TabIndex = 5;
            this.neuenKundeButton.Text = "Neu ...";
            this.neuenKundeButton.UseVisualStyleBackColor = true;
            this.neuenKundeButton.Click += new System.EventHandler(this.neuenKundeButton_Click);
            // 
            // kundeNummerAufrufenButton
            // 
            this.kundeNummerAufrufenButton.Location = new System.Drawing.Point(132, 536);
            this.kundeNummerAufrufenButton.Name = "kundeNummerAufrufenButton";
            this.kundeNummerAufrufenButton.Size = new System.Drawing.Size(62, 23);
            this.kundeNummerAufrufenButton.TabIndex = 4;
            this.kundeNummerAufrufenButton.Text = "Los";
            this.kundeNummerAufrufenButton.UseVisualStyleBackColor = true;
            this.kundeNummerAufrufenButton.Click += new System.EventHandler(this.kundeNummerAufrufenButton_Click);
            // 
            // kundenNummerAufrufenNumericUpDown
            // 
            this.kundenNummerAufrufenNumericUpDown.Location = new System.Drawing.Point(6, 536);
            this.kundenNummerAufrufenNumericUpDown.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.kundenNummerAufrufenNumericUpDown.Name = "kundenNummerAufrufenNumericUpDown";
            this.kundenNummerAufrufenNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.kundenNummerAufrufenNumericUpDown.TabIndex = 3;
            // 
            // kundenListBox
            // 
            this.kundenListBox.FormattingEnabled = true;
            this.kundenListBox.Location = new System.Drawing.Point(6, 19);
            this.kundenListBox.Name = "kundenListBox";
            this.kundenListBox.Size = new System.Drawing.Size(188, 446);
            this.kundenListBox.TabIndex = 1;
            this.kundenListBox.DoubleClick += new System.EventHandler(this.kundenListBox_DoubleClick);
            this.kundenListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kundenListBox_KeyUp);
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.kundeGroupBox);
            this.Name = "ViewMain";
            this.Text = "ViewMain";
            this.Load += new System.EventHandler(this.ViewMain_Load);
            this.kundeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.kundenNummerAufrufenNumericUpDown)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button neuenKundeButton;

        private System.Windows.Forms.NumericUpDown kundenNummerAufrufenNumericUpDown;
        private System.Windows.Forms.Button kundeNummerAufrufenButton;

        private System.Windows.Forms.ListBox kundenListBox;

        private System.Windows.Forms.GroupBox kundeGroupBox;

        #endregion
    }
}