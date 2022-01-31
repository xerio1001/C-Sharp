namespace Opdracht25Dario
{
    partial class FrmOpdracht25Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht25Dario));
            this.BtnBerekenen = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.LblCONTAINER = new System.Windows.Forms.Label();
            this.LblWeekgeld = new System.Windows.Forms.Label();
            this.TxtWeekgeld = new System.Windows.Forms.TextBox();
            this.TxtVerhoging = new System.Windows.Forms.TextBox();
            this.LblVerhoging = new System.Windows.Forms.Label();
            this.TxtGewenstBedrag = new System.Windows.Forms.TextBox();
            this.LblGewenstBedrag = new System.Windows.Forms.Label();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBerekenen
            // 
            this.BtnBerekenen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBerekenen.Location = new System.Drawing.Point(529, 12);
            this.BtnBerekenen.Name = "BtnBerekenen";
            this.BtnBerekenen.Size = new System.Drawing.Size(130, 37);
            this.BtnBerekenen.TabIndex = 0;
            this.BtnBerekenen.Text = "&Berekenen";
            this.BtnBerekenen.UseVisualStyleBackColor = true;
            this.BtnBerekenen.Click += new System.EventHandler(this.BtnBerekenen_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(529, 55);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(130, 37);
            this.BtnWissen.TabIndex = 1;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(529, 98);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(130, 37);
            this.BtnSluiten.TabIndex = 2;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // LblCONTAINER
            // 
            this.LblCONTAINER.Location = new System.Drawing.Point(273, 152);
            this.LblCONTAINER.Name = "LblCONTAINER";
            this.LblCONTAINER.Size = new System.Drawing.Size(386, 139);
            this.LblCONTAINER.TabIndex = 3;
            // 
            // LblWeekgeld
            // 
            this.LblWeekgeld.AutoSize = true;
            this.LblWeekgeld.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblWeekgeld.Location = new System.Drawing.Point(390, 171);
            this.LblWeekgeld.Name = "LblWeekgeld";
            this.LblWeekgeld.Size = new System.Drawing.Size(99, 25);
            this.LblWeekgeld.TabIndex = 4;
            this.LblWeekgeld.Text = "Weekgeld:";
            // 
            // TxtWeekgeld
            // 
            this.TxtWeekgeld.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtWeekgeld.Location = new System.Drawing.Point(495, 168);
            this.TxtWeekgeld.Name = "TxtWeekgeld";
            this.TxtWeekgeld.Size = new System.Drawing.Size(150, 32);
            this.TxtWeekgeld.TabIndex = 5;
            // 
            // TxtVerhoging
            // 
            this.TxtVerhoging.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVerhoging.Location = new System.Drawing.Point(495, 206);
            this.TxtVerhoging.Name = "TxtVerhoging";
            this.TxtVerhoging.Size = new System.Drawing.Size(150, 32);
            this.TxtVerhoging.TabIndex = 7;
            // 
            // LblVerhoging
            // 
            this.LblVerhoging.AutoSize = true;
            this.LblVerhoging.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVerhoging.Location = new System.Drawing.Point(284, 209);
            this.LblVerhoging.Name = "LblVerhoging";
            this.LblVerhoging.Size = new System.Drawing.Size(205, 25);
            this.LblVerhoging.TabIndex = 6;
            this.LblVerhoging.Text = "Weekelijkse verhoging:";
            // 
            // TxtGewenstBedrag
            // 
            this.TxtGewenstBedrag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGewenstBedrag.Location = new System.Drawing.Point(495, 244);
            this.TxtGewenstBedrag.Name = "TxtGewenstBedrag";
            this.TxtGewenstBedrag.Size = new System.Drawing.Size(150, 32);
            this.TxtGewenstBedrag.TabIndex = 9;
            // 
            // LblGewenstBedrag
            // 
            this.LblGewenstBedrag.AutoSize = true;
            this.LblGewenstBedrag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGewenstBedrag.Location = new System.Drawing.Point(290, 247);
            this.LblGewenstBedrag.Name = "LblGewenstBedrag";
            this.LblGewenstBedrag.Size = new System.Drawing.Size(199, 25);
            this.LblGewenstBedrag.TabIndex = 8;
            this.LblGewenstBedrag.Text = "Gewenst spaarbedrag:";
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(273, 305);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(386, 133);
            this.TxtResultaat.TabIndex = 10;
            // 
            // FrmOpdracht25Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Opdracht25Dario.Properties.Resources.spaargeld_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.TxtGewenstBedrag);
            this.Controls.Add(this.LblGewenstBedrag);
            this.Controls.Add(this.TxtVerhoging);
            this.Controls.Add(this.LblVerhoging);
            this.Controls.Add(this.TxtWeekgeld);
            this.Controls.Add(this.LblWeekgeld);
            this.Controls.Add(this.LblCONTAINER);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBerekenen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht25Dario";
            this.Text = "zakgeld berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnBerekenen;
        private Button BtnWissen;
        private Button BtnSluiten;
        private Label LblCONTAINER;
        private Label LblWeekgeld;
        private TextBox TxtWeekgeld;
        private TextBox TxtVerhoging;
        private Label LblVerhoging;
        private TextBox TxtGewenstBedrag;
        private Label LblGewenstBedrag;
        private TextBox TxtResultaat;
    }
}