namespace TrackerUIForms
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.LblTeamsPlayers = new System.Windows.Forms.Label();
            this.TournamentTeamsListbox = new System.Windows.Forms.ListBox();
            this.BtnCreatePrize = new System.Windows.Forms.Button();
            this.BtnAddTeam = new System.Windows.Forms.Button();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.LblSelectTeam = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.LblEntryFee = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.LblTournamentName = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnRemoveSelectedPrizes = new System.Windows.Forms.Button();
            this.LblPrizes = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.BtnRemoveSelectedPlayer = new System.Windows.Forms.Button();
            this.BtnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTeamsPlayers
            // 
            this.LblTeamsPlayers.AutoSize = true;
            this.LblTeamsPlayers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTeamsPlayers.Location = new System.Drawing.Point(367, 85);
            this.LblTeamsPlayers.Name = "LblTeamsPlayers";
            this.LblTeamsPlayers.Size = new System.Drawing.Size(164, 30);
            this.LblTeamsPlayers.TabIndex = 23;
            this.LblTeamsPlayers.Text = "Teams / players";
            // 
            // TournamentTeamsListbox
            // 
            this.TournamentTeamsListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentTeamsListbox.FormattingEnabled = true;
            this.TournamentTeamsListbox.ItemHeight = 30;
            this.TournamentTeamsListbox.Location = new System.Drawing.Point(370, 118);
            this.TournamentTeamsListbox.Name = "TournamentTeamsListbox";
            this.TournamentTeamsListbox.Size = new System.Drawing.Size(331, 122);
            this.TournamentTeamsListbox.TabIndex = 22;
            // 
            // BtnCreatePrize
            // 
            this.BtnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreatePrize.Location = new System.Drawing.Point(85, 404);
            this.BtnCreatePrize.Name = "BtnCreatePrize";
            this.BtnCreatePrize.Size = new System.Drawing.Size(145, 44);
            this.BtnCreatePrize.TabIndex = 21;
            this.BtnCreatePrize.Text = "Create prize";
            this.BtnCreatePrize.UseVisualStyleBackColor = true;
            this.BtnCreatePrize.Click += new System.EventHandler(this.BtnCreatePrize_Click);
            // 
            // BtnAddTeam
            // 
            this.BtnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddTeam.Location = new System.Drawing.Point(85, 341);
            this.BtnAddTeam.Name = "BtnAddTeam";
            this.BtnAddTeam.Size = new System.Drawing.Size(145, 44);
            this.BtnAddTeam.TabIndex = 20;
            this.BtnAddTeam.Text = "Add team";
            this.BtnAddTeam.UseVisualStyleBackColor = true;
            this.BtnAddTeam.Click += new System.EventHandler(this.BtnAddTeam_Click);
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateNewTeamLink.Location = new System.Drawing.Point(217, 262);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(88, 21);
            this.CreateNewTeamLink.TabIndex = 19;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create new";
            this.CreateNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewTeamLink_LinkClicked);
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(12, 288);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(293, 38);
            this.SelectTeamDropDown.TabIndex = 18;
            // 
            // LblSelectTeam
            // 
            this.LblSelectTeam.AutoSize = true;
            this.LblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSelectTeam.Location = new System.Drawing.Point(12, 255);
            this.LblSelectTeam.Name = "LblSelectTeam";
            this.LblSelectTeam.Size = new System.Drawing.Size(129, 30);
            this.LblSelectTeam.TabIndex = 17;
            this.LblSelectTeam.Text = "Select Team";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(117, 182);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(188, 36);
            this.entryFeeValue.TabIndex = 16;
            this.entryFeeValue.Text = "0";
            // 
            // LblEntryFee
            // 
            this.LblEntryFee.AutoSize = true;
            this.LblEntryFee.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEntryFee.Location = new System.Drawing.Point(12, 185);
            this.LblEntryFee.Name = "LblEntryFee";
            this.LblEntryFee.Size = new System.Drawing.Size(103, 30);
            this.LblEntryFee.TabIndex = 15;
            this.LblEntryFee.Text = "Entry Fee";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(12, 118);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(293, 36);
            this.TournamentNameValue.TabIndex = 14;
            // 
            // LblTournamentName
            // 
            this.LblTournamentName.AutoSize = true;
            this.LblTournamentName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTournamentName.Location = new System.Drawing.Point(12, 85);
            this.LblTournamentName.Name = "LblTournamentName";
            this.LblTournamentName.Size = new System.Drawing.Size(189, 30);
            this.LblTournamentName.TabIndex = 13;
            this.LblTournamentName.Text = "Tournament name";
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHeader.Location = new System.Drawing.Point(318, 9);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(261, 37);
            this.LblHeader.TabIndex = 12;
            this.LblHeader.Text = "Create tournament";
            // 
            // BtnRemoveSelectedPrizes
            // 
            this.BtnRemoveSelectedPrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveSelectedPrizes.Location = new System.Drawing.Point(716, 314);
            this.BtnRemoveSelectedPrizes.Name = "BtnRemoveSelectedPrizes";
            this.BtnRemoveSelectedPrizes.Size = new System.Drawing.Size(126, 71);
            this.BtnRemoveSelectedPrizes.TabIndex = 27;
            this.BtnRemoveSelectedPrizes.Text = "Remove selected";
            this.BtnRemoveSelectedPrizes.UseVisualStyleBackColor = true;
            this.BtnRemoveSelectedPrizes.Click += new System.EventHandler(this.BtnRemoveSelectedPrizes_Click);
            // 
            // LblPrizes
            // 
            this.LblPrizes.AutoSize = true;
            this.LblPrizes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrizes.Location = new System.Drawing.Point(367, 255);
            this.LblPrizes.Name = "LblPrizes";
            this.LblPrizes.Size = new System.Drawing.Size(69, 30);
            this.LblPrizes.TabIndex = 26;
            this.LblPrizes.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 30;
            this.PrizesListBox.Location = new System.Drawing.Point(370, 288);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(331, 122);
            this.PrizesListBox.TabIndex = 25;
            // 
            // BtnRemoveSelectedPlayer
            // 
            this.BtnRemoveSelectedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveSelectedPlayer.Location = new System.Drawing.Point(716, 145);
            this.BtnRemoveSelectedPlayer.Name = "BtnRemoveSelectedPlayer";
            this.BtnRemoveSelectedPlayer.Size = new System.Drawing.Size(126, 73);
            this.BtnRemoveSelectedPlayer.TabIndex = 28;
            this.BtnRemoveSelectedPlayer.Text = "Remove selected";
            this.BtnRemoveSelectedPlayer.UseVisualStyleBackColor = true;
            this.BtnRemoveSelectedPlayer.Click += new System.EventHandler(this.BtnRemoveSelectedPlayer_Click);
            // 
            // BtnCreateTournament
            // 
            this.BtnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateTournament.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateTournament.Location = new System.Drawing.Point(318, 454);
            this.BtnCreateTournament.Name = "BtnCreateTournament";
            this.BtnCreateTournament.Size = new System.Drawing.Size(240, 44);
            this.BtnCreateTournament.TabIndex = 29;
            this.BtnCreateTournament.Text = "Create tournament";
            this.BtnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 522);
            this.Controls.Add(this.BtnCreateTournament);
            this.Controls.Add(this.BtnRemoveSelectedPlayer);
            this.Controls.Add(this.BtnRemoveSelectedPrizes);
            this.Controls.Add(this.LblPrizes);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.LblTeamsPlayers);
            this.Controls.Add(this.TournamentTeamsListbox);
            this.Controls.Add(this.BtnCreatePrize);
            this.Controls.Add(this.BtnAddTeam);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.LblSelectTeam);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.LblEntryFee);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.LblTournamentName);
            this.Controls.Add(this.LblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTeamsPlayers;
        private ListBox TournamentTeamsListbox;
        private Button BtnCreatePrize;
        private Button BtnAddTeam;
        private LinkLabel CreateNewTeamLink;
        private ComboBox SelectTeamDropDown;
        private Label LblSelectTeam;
        private TextBox entryFeeValue;
        private Label LblEntryFee;
        private TextBox TournamentNameValue;
        private Label LblTournamentName;
        private Label LblHeader;
        private Button BtnRemoveSelectedPrizes;
        private Label LblPrizes;
        private ListBox PrizesListBox;
        private Button BtnRemoveSelectedPlayer;
        private Button BtnCreateTournament;
    }
}