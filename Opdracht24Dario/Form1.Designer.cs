namespace Opdracht24Dario
{
    partial class FrmOpdracht24Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht24Dario));
            this.TxtLand = new System.Windows.Forms.TextBox();
            this.LblLand = new System.Windows.Forms.Label();
            this.LblHuidigBevolk = new System.Windows.Forms.Label();
            this.TxtHuidigBevolk = new System.Windows.Forms.TextBox();
            this.LblGroeiPerc = new System.Windows.Forms.Label();
            this.TxtGroeiperc = new System.Windows.Forms.TextBox();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtLand
            // 
            this.TxtLand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLand.Location = new System.Drawing.Point(428, 74);
            this.TxtLand.Name = "TxtLand";
            this.TxtLand.Size = new System.Drawing.Size(185, 32);
            this.TxtLand.TabIndex = 0;
            // 
            // LblLand
            // 
            this.LblLand.AutoSize = true;
            this.LblLand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLand.Location = new System.Drawing.Point(365, 77);
            this.LblLand.Name = "LblLand";
            this.LblLand.Size = new System.Drawing.Size(57, 25);
            this.LblLand.TabIndex = 1;
            this.LblLand.Text = "Land:";
            // 
            // LblHuidigBevolk
            // 
            this.LblHuidigBevolk.AutoSize = true;
            this.LblHuidigBevolk.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHuidigBevolk.Location = new System.Drawing.Point(203, 115);
            this.LblHuidigBevolk.Name = "LblHuidigBevolk";
            this.LblHuidigBevolk.Size = new System.Drawing.Size(219, 25);
            this.LblHuidigBevolk.TabIndex = 3;
            this.LblHuidigBevolk.Text = "Huidig bevolkingsaantal:";
            // 
            // TxtHuidigBevolk
            // 
            this.TxtHuidigBevolk.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtHuidigBevolk.Location = new System.Drawing.Point(428, 112);
            this.TxtHuidigBevolk.Name = "TxtHuidigBevolk";
            this.TxtHuidigBevolk.Size = new System.Drawing.Size(185, 32);
            this.TxtHuidigBevolk.TabIndex = 2;
            // 
            // LblGroeiPerc
            // 
            this.LblGroeiPerc.AutoSize = true;
            this.LblGroeiPerc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGroeiPerc.Location = new System.Drawing.Point(265, 153);
            this.LblGroeiPerc.Name = "LblGroeiPerc";
            this.LblGroeiPerc.Size = new System.Drawing.Size(157, 25);
            this.LblGroeiPerc.TabIndex = 5;
            this.LblGroeiPerc.Text = "Groeipercentage:";
            // 
            // TxtGroeiperc
            // 
            this.TxtGroeiperc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGroeiperc.Location = new System.Drawing.Point(428, 150);
            this.TxtGroeiperc.Name = "TxtGroeiperc";
            this.TxtGroeiperc.Size = new System.Drawing.Size(185, 32);
            this.TxtGroeiperc.TabIndex = 4;
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(92, 207);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(521, 187);
            this.TxtResultaat.TabIndex = 6;
            // 
            // BtnBereken
            // 
            this.BtnBereken.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(641, 231);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(122, 36);
            this.BtnBereken.TabIndex = 7;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(641, 273);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(122, 36);
            this.BtnWissen.TabIndex = 8;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(641, 315);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(122, 36);
            this.BtnSluiten.TabIndex = 9;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmOpdracht24Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.LblGroeiPerc);
            this.Controls.Add(this.TxtGroeiperc);
            this.Controls.Add(this.LblHuidigBevolk);
            this.Controls.Add(this.TxtHuidigBevolk);
            this.Controls.Add(this.LblLand);
            this.Controls.Add(this.TxtLand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht24Dario";
            this.Text = "Berekening bevolkingsverdubbeling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtLand;
        private Label LblLand;
        private Label LblHuidigBevolk;
        private TextBox TxtHuidigBevolk;
        private Label LblGroeiPerc;
        private TextBox TxtGroeiperc;
        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}