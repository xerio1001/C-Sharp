namespace DebugTest
{
    partial class FrmDebuggen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDebuggen));
            this.BtnGo = new System.Windows.Forms.Button();
            this.TxtResultaat = new System.Windows.Forms.TextBox();
            this.LblTitel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGo
            // 
            this.BtnGo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGo.Location = new System.Drawing.Point(131, 105);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(95, 53);
            this.BtnGo.TabIndex = 0;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // TxtResultaat
            // 
            this.TxtResultaat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtResultaat.Location = new System.Drawing.Point(58, 179);
            this.TxtResultaat.Multiline = true;
            this.TxtResultaat.Name = "TxtResultaat";
            this.TxtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResultaat.Size = new System.Drawing.Size(234, 106);
            this.TxtResultaat.TabIndex = 1;
            // 
            // LblTitel
            // 
            this.LblTitel.AutoSize = true;
            this.LblTitel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitel.Location = new System.Drawing.Point(108, 42);
            this.LblTitel.Name = "LblTitel";
            this.LblTitel.Size = new System.Drawing.Size(142, 37);
            this.LblTitel.TabIndex = 2;
            this.LblTitel.Text = "Debuggen";
            // 
            // FrmDebuggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 344);
            this.Controls.Add(this.LblTitel);
            this.Controls.Add(this.TxtResultaat);
            this.Controls.Add(this.BtnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDebuggen";
            this.Text = "Debuggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnGo;
        private TextBox TxtResultaat;
        private Label LblTitel;
    }
}