namespace TrackerUIForms
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.LblHeader = new System.Windows.Forms.Label();
            this.LoadExistingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.LblLoadExistingTournament = new System.Windows.Forms.Label();
            this.BtnLoadTournament = new System.Windows.Forms.Button();
            this.BtnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LblHeader.Location = new System.Drawing.Point(34, 34);
            this.LblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(374, 45);
            this.LblHeader.TabIndex = 35;
            this.LblHeader.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentDropdown
            // 
            this.LoadExistingTournamentDropdown.FormattingEnabled = true;
            this.LoadExistingTournamentDropdown.Location = new System.Drawing.Point(77, 136);
            this.LoadExistingTournamentDropdown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LoadExistingTournamentDropdown.Name = "LoadExistingTournamentDropdown";
            this.LoadExistingTournamentDropdown.Size = new System.Drawing.Size(289, 38);
            this.LoadExistingTournamentDropdown.TabIndex = 37;
            // 
            // LblLoadExistingTournament
            // 
            this.LblLoadExistingTournament.AutoSize = true;
            this.LblLoadExistingTournament.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLoadExistingTournament.Location = new System.Drawing.Point(91, 100);
            this.LblLoadExistingTournament.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblLoadExistingTournament.Name = "LblLoadExistingTournament";
            this.LblLoadExistingTournament.Size = new System.Drawing.Size(260, 30);
            this.LblLoadExistingTournament.TabIndex = 36;
            this.LblLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // BtnLoadTournament
            // 
            this.BtnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadTournament.Location = new System.Drawing.Point(115, 197);
            this.BtnLoadTournament.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnLoadTournament.Name = "BtnLoadTournament";
            this.BtnLoadTournament.Size = new System.Drawing.Size(212, 44);
            this.BtnLoadTournament.TabIndex = 38;
            this.BtnLoadTournament.Text = "Load Tournament";
            this.BtnLoadTournament.UseVisualStyleBackColor = true;
            this.BtnLoadTournament.Click += new System.EventHandler(this.BtnLoadTournament_Click);
            // 
            // BtnCreateTournament
            // 
            this.BtnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateTournament.Location = new System.Drawing.Point(115, 253);
            this.BtnCreateTournament.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnCreateTournament.Name = "BtnCreateTournament";
            this.BtnCreateTournament.Size = new System.Drawing.Size(212, 44);
            this.BtnCreateTournament.TabIndex = 39;
            this.BtnCreateTournament.Text = "Create Tournament";
            this.BtnCreateTournament.UseVisualStyleBackColor = true;
            this.BtnCreateTournament.Click += new System.EventHandler(this.BtnCreateTournament_Click);
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 334);
            this.Controls.Add(this.BtnCreateTournament);
            this.Controls.Add(this.BtnLoadTournament);
            this.Controls.Add(this.LoadExistingTournamentDropdown);
            this.Controls.Add(this.LblLoadExistingTournament);
            this.Controls.Add(this.LblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblHeader;
        private ComboBox LoadExistingTournamentDropdown;
        private Label LblLoadExistingTournament;
        private Button BtnLoadTournament;
        private Button BtnCreateTournament;
    }
}