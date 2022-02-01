namespace Opdracht27Dario
{
    partial class FrmOpdracht27Dario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht27Dario));
            this.LblHexaDecGetal = new System.Windows.Forms.Label();
            this.TxtHexaDecGetal = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.LblDecGetal = new System.Windows.Forms.Label();
            this.BtnOmzetten = new System.Windows.Forms.Button();
            this.BtnOpnieuw = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHexaDecGetal
            // 
            this.LblHexaDecGetal.AutoSize = true;
            this.LblHexaDecGetal.BackColor = System.Drawing.Color.Transparent;
            this.LblHexaDecGetal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHexaDecGetal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblHexaDecGetal.Location = new System.Drawing.Point(198, 112);
            this.LblHexaDecGetal.Name = "LblHexaDecGetal";
            this.LblHexaDecGetal.Size = new System.Drawing.Size(130, 50);
            this.LblHexaDecGetal.TabIndex = 0;
            this.LblHexaDecGetal.Text = "Hexadecimale\r\nwaarde";
            // 
            // TxtHexaDecGetal
            // 
            this.TxtHexaDecGetal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtHexaDecGetal.Location = new System.Drawing.Point(198, 165);
            this.TxtHexaDecGetal.Multiline = true;
            this.TxtHexaDecGetal.Name = "TxtHexaDecGetal";
            this.TxtHexaDecGetal.Size = new System.Drawing.Size(130, 39);
            this.TxtHexaDecGetal.TabIndex = 1;
            this.TxtHexaDecGetal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHexaDecGetal_KeyPress);
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(406, 165);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(128, 39);
            this.TxtResultaat.TabIndex = 3;
            // 
            // LblDecGetal
            // 
            this.LblDecGetal.AutoSize = true;
            this.LblDecGetal.BackColor = System.Drawing.Color.Transparent;
            this.LblDecGetal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDecGetal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDecGetal.Location = new System.Drawing.Point(406, 112);
            this.LblDecGetal.Name = "LblDecGetal";
            this.LblDecGetal.Size = new System.Drawing.Size(90, 50);
            this.LblDecGetal.TabIndex = 2;
            this.LblDecGetal.Text = "Decimale\r\nwaarde";
            // 
            // BtnOmzetten
            // 
            this.BtnOmzetten.BackColor = System.Drawing.Color.Green;
            this.BtnOmzetten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOmzetten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOmzetten.Location = new System.Drawing.Point(198, 241);
            this.BtnOmzetten.Name = "BtnOmzetten";
            this.BtnOmzetten.Size = new System.Drawing.Size(108, 39);
            this.BtnOmzetten.TabIndex = 4;
            this.BtnOmzetten.Text = "&Zet om";
            this.BtnOmzetten.UseVisualStyleBackColor = false;
            this.BtnOmzetten.Click += new System.EventHandler(this.BtnOmzetten_Click);
            // 
            // BtnOpnieuw
            // 
            this.BtnOpnieuw.BackColor = System.Drawing.Color.Black;
            this.BtnOpnieuw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOpnieuw.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOpnieuw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnOpnieuw.Location = new System.Drawing.Point(312, 241);
            this.BtnOpnieuw.Name = "BtnOpnieuw";
            this.BtnOpnieuw.Size = new System.Drawing.Size(108, 39);
            this.BtnOpnieuw.TabIndex = 5;
            this.BtnOpnieuw.Text = "&Opnieuw";
            this.BtnOpnieuw.UseVisualStyleBackColor = false;
            this.BtnOpnieuw.Click += new System.EventHandler(this.BtnOpnieuw_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.BackColor = System.Drawing.Color.Maroon;
            this.BtnSluiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSluiten.Location = new System.Drawing.Point(426, 241);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(108, 39);
            this.BtnSluiten.TabIndex = 6;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = false;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmOpdracht27Dario
            // 
            this.AcceptButton = this.BtnOmzetten;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Opdracht27Dario.Properties.Resources.hexadecimalBackground2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 420);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnOpnieuw);
            this.Controls.Add(this.BtnOmzetten);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.LblDecGetal);
            this.Controls.Add(this.TxtHexaDecGetal);
            this.Controls.Add(this.LblHexaDecGetal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht27Dario";
            this.Text = "Tafelstelsel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblHexaDecGetal;
        private TextBox TxtHexaDecGetal;
        private TextBox TxtResultaat;
        private Label LblDecGetal;
        private Button BtnOmzetten;
        private Button BtnOpnieuw;
        private Button BtnSluiten;
    }
}