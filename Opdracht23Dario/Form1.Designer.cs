namespace Opdracht23Dario
{
    partial class FrmOpdracht23Dario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpdracht23Dario));
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnOpnieuw = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(61, 49);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResultaat.Size = new System.Drawing.Size(325, 276);
            this.TxtResultaat.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.Location = new System.Drawing.Point(408, 105);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(131, 39);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnOpnieuw
            // 
            this.BtnOpnieuw.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOpnieuw.Location = new System.Drawing.Point(408, 168);
            this.BtnOpnieuw.Name = "BtnOpnieuw";
            this.BtnOpnieuw.Size = new System.Drawing.Size(131, 39);
            this.BtnOpnieuw.TabIndex = 2;
            this.BtnOpnieuw.Text = "&Opnieuw";
            this.BtnOpnieuw.UseVisualStyleBackColor = true;
            this.BtnOpnieuw.Click += new System.EventHandler(this.BtnOpnieuw_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(408, 235);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(131, 39);
            this.BtnSluiten.TabIndex = 3;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // FrmOpdracht23Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 387);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnOpnieuw);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtResultaat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpdracht23Dario";
            this.Text = "Dobbelsteenworpen tot gooien van 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtResultaat;
        private Button BtnStart;
        private Button BtnOpnieuw;
        private Button BtnSluiten;
    }
}