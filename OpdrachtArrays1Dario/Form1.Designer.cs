namespace OpdrachtArrays1Dario
{
    partial class Form1
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
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.BtnWissen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(102, 56);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResultaat.Size = new System.Drawing.Size(247, 295);
            this.TxtResultaat.TabIndex = 0;
            // 
            // BtnBereken
            // 
            this.BtnBereken.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBereken.Location = new System.Drawing.Point(368, 145);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(119, 39);
            this.BtnBereken.TabIndex = 1;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = true;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(368, 190);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(119, 39);
            this.BtnSluiten.TabIndex = 2;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // BtnWissen
            // 
            this.BtnWissen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWissen.Location = new System.Drawing.Point(368, 235);
            this.BtnWissen.Name = "BtnWissen";
            this.BtnWissen.Size = new System.Drawing.Size(119, 39);
            this.BtnWissen.TabIndex = 3;
            this.BtnWissen.Text = "&Wissen";
            this.BtnWissen.UseVisualStyleBackColor = true;
            this.BtnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.BtnWissen);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.TxtResultaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtResultaat;
        private Button BtnBereken;
        private Button BtnSluiten;
        private Button BtnWissen;
    }
}