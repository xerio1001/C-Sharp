namespace OpdrachtArrays3Dario
{
    partial class FrmOpdrachtArrays3Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdrachtArrays3Dario));
            this.TxtTotaalBedrag = new System.Windows.Forms.TextBox();
            this.LblBedrag = new System.Windows.Forms.Label();
            this.LblAantal = new System.Windows.Forms.Label();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTotaalBedrag
            // 
            this.TxtTotaalBedrag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTotaalBedrag.Location = new System.Drawing.Point(85, 89);
            this.TxtTotaalBedrag.Name = "TxtTotaalBedrag";
            this.TxtTotaalBedrag.Size = new System.Drawing.Size(174, 32);
            this.TxtTotaalBedrag.TabIndex = 0;
            // 
            // LblBedrag
            // 
            this.LblBedrag.AutoSize = true;
            this.LblBedrag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBedrag.Location = new System.Drawing.Point(85, 61);
            this.LblBedrag.Name = "LblBedrag";
            this.LblBedrag.Size = new System.Drawing.Size(76, 25);
            this.LblBedrag.TabIndex = 1;
            this.LblBedrag.Text = "Bedrag:";
            // 
            // LblAantal
            // 
            this.LblAantal.AutoSize = true;
            this.LblAantal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAantal.Location = new System.Drawing.Point(85, 143);
            this.LblAantal.Name = "LblAantal";
            this.LblAantal.Size = new System.Drawing.Size(70, 25);
            this.LblAantal.TabIndex = 3;
            this.LblAantal.Text = "Aantal:";
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Enabled = false;
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(85, 171);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.Size = new System.Drawing.Size(298, 248);
            this.TxtResultaat.TabIndex = 2;
            // 
            // BtnBereken
            // 
            this.BtnBereken.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(412, 175);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(131, 40);
            this.BtnBereken.TabIndex = 4;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(412, 230);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(131, 40);
            this.BtnWissen.TabIndex = 5;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(412, 286);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(131, 40);
            this.BtnSluiten.TabIndex = 6;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmOpdrachtArrays3Dario
            // 
            this.AcceptButton = this.BtnBereken;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSluiten;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.LblAantal);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.LblBedrag);
            this.Controls.Add(this.TxtTotaalBedrag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdrachtArrays3Dario";
            this.Text = "Berekening coupures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtTotaalBedrag;
        private Label LblBedrag;
        private Label LblAantal;
        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnWissen;
        private Button BtnSluiten;
    }
}