namespace Project1
{
    partial class FrmFuel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuel));
            this.LblKilometers = new System.Windows.Forms.Label();
            this.LblLiters = new System.Windows.Forms.Label();
            this.LblVerbruik = new System.Windows.Forms.Label();
            this.BtnBereken = new System.Windows.Forms.Button();
            this.TxtKilometers = new System.Windows.Forms.TextBox();
            this.TxtLiters = new System.Windows.Forms.TextBox();
            this.TxtVerbruik = new System.Windows.Forms.TextBox();
            this.BtnLeegmaken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblKilometers
            // 
            this.LblKilometers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblKilometers.Location = new System.Drawing.Point(38, 23);
            this.LblKilometers.Name = "LblKilometers";
            this.LblKilometers.Size = new System.Drawing.Size(190, 25);
            this.LblKilometers.TabIndex = 0;
            this.LblKilometers.Text = "Kilometers gereden:";
            this.LblKilometers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblKilometers.Click += new System.EventHandler(this.LblKilometers_Click);
            // 
            // LblLiters
            // 
            this.LblLiters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblLiters.Location = new System.Drawing.Point(38, 56);
            this.LblLiters.Name = "LblLiters";
            this.LblLiters.Size = new System.Drawing.Size(190, 25);
            this.LblLiters.TabIndex = 1;
            this.LblLiters.Text = "Liters getankt:";
            this.LblLiters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblVerbruik
            // 
            this.LblVerbruik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblVerbruik.Location = new System.Drawing.Point(38, 106);
            this.LblVerbruik.Name = "LblVerbruik";
            this.LblVerbruik.Size = new System.Drawing.Size(190, 25);
            this.LblVerbruik.TabIndex = 2;
            this.LblVerbruik.Text = "Gemiddelde verbruik:";
            this.LblVerbruik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnBereken
            // 
            this.BtnBereken.AutoSize = true;
            this.BtnBereken.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBereken.Location = new System.Drawing.Point(141, 142);
            this.BtnBereken.Name = "BtnBereken";
            this.BtnBereken.Size = new System.Drawing.Size(87, 29);
            this.BtnBereken.TabIndex = 3;
            this.BtnBereken.Text = "&Bereken";
            this.BtnBereken.UseVisualStyleBackColor = false;
            this.BtnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // TxtKilometers
            // 
            this.TxtKilometers.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtKilometers.Location = new System.Drawing.Point(234, 23);
            this.TxtKilometers.Name = "TxtKilometers";
            this.TxtKilometers.Size = new System.Drawing.Size(113, 27);
            this.TxtKilometers.TabIndex = 4;
            // 
            // TxtLiters
            // 
            this.TxtLiters.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtLiters.Location = new System.Drawing.Point(234, 56);
            this.TxtLiters.Name = "TxtLiters";
            this.TxtLiters.Size = new System.Drawing.Size(113, 27);
            this.TxtLiters.TabIndex = 5;
            // 
            // TxtVerbruik
            // 
            this.TxtVerbruik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtVerbruik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVerbruik.Enabled = false;
            this.TxtVerbruik.Location = new System.Drawing.Point(234, 109);
            this.TxtVerbruik.Name = "TxtVerbruik";
            this.TxtVerbruik.Size = new System.Drawing.Size(113, 20);
            this.TxtVerbruik.TabIndex = 6;
            // 
            // BtnLeegmaken
            // 
            this.BtnLeegmaken.AutoSize = true;
            this.BtnLeegmaken.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLeegmaken.Location = new System.Drawing.Point(234, 142);
            this.BtnLeegmaken.Name = "BtnLeegmaken";
            this.BtnLeegmaken.Size = new System.Drawing.Size(113, 29);
            this.BtnLeegmaken.TabIndex = 7;
            this.BtnLeegmaken.Text = "&Leegmaken";
            this.BtnLeegmaken.UseVisualStyleBackColor = false;
            this.BtnLeegmaken.Click += new System.EventHandler(this.BtnLeegmaken_Click);
            // 
            // FrmFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 205);
            this.Controls.Add(this.BtnLeegmaken);
            this.Controls.Add(this.TxtVerbruik);
            this.Controls.Add(this.TxtLiters);
            this.Controls.Add(this.TxtKilometers);
            this.Controls.Add(this.BtnBereken);
            this.Controls.Add(this.LblVerbruik);
            this.Controls.Add(this.LblLiters);
            this.Controls.Add(this.LblKilometers);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFuel";
            this.Text = "Bereken Brandstof";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblKilometers;
        private Label LblLiters;
        private Label LblVerbruik;
        private Button BtnBereken;
        private TextBox TxtKilometers;
        private TextBox TxtLiters;
        private TextBox TxtVerbruik;
        private Button BtnLeegmaken;
    }
}