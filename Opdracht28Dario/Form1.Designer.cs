namespace Opdracht28Dario
{
    partial class FrmOpdracht28Dario
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
            this.LblMainTitel = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnSluiten = new System.Windows.Forms.Button();
            this.PicBoxResultaat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxResultaat)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMainTitel
            // 
            this.LblMainTitel.AutoSize = true;
            this.LblMainTitel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMainTitel.Location = new System.Drawing.Point(34, 34);
            this.LblMainTitel.Name = "LblMainTitel";
            this.LblMainTitel.Size = new System.Drawing.Size(506, 25);
            this.LblMainTitel.TabIndex = 0;
            this.LblMainTitel.Text = "Raad zo snel mogelijk het willekeurig getal tussen 0 en 100";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.Location = new System.Drawing.Point(223, 91);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(130, 37);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnSluiten
            // 
            this.BtnSluiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSluiten.Location = new System.Drawing.Point(223, 134);
            this.BtnSluiten.Name = "BtnSluiten";
            this.BtnSluiten.Size = new System.Drawing.Size(130, 37);
            this.BtnSluiten.TabIndex = 2;
            this.BtnSluiten.Text = "&Sluiten";
            this.BtnSluiten.UseVisualStyleBackColor = true;
            this.BtnSluiten.Click += new System.EventHandler(this.BtnSluiten_Click);
            // 
            // PicBoxResultaat
            // 
            this.PicBoxResultaat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxResultaat.Image = global::Opdracht28Dario.Properties.Resources.goodJobSmall;
            this.PicBoxResultaat.Location = new System.Drawing.Point(420, 91);
            this.PicBoxResultaat.Name = "PicBoxResultaat";
            this.PicBoxResultaat.Size = new System.Drawing.Size(120, 126);
            this.PicBoxResultaat.TabIndex = 3;
            this.PicBoxResultaat.TabStop = false;
            this.PicBoxResultaat.UseWaitCursor = true;
            // 
            // FrmOpdracht28Dario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 250);
            this.Controls.Add(this.PicBoxResultaat);
            this.Controls.Add(this.BtnSluiten);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblMainTitel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmOpdracht28Dario";
            this.Text = "Raadspel";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxResultaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblMainTitel;
        private Button BtnStart;
        private Button BtnSluiten;
        private PictureBox PicBoxResultaat;
    }
}