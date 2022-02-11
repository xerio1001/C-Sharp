namespace TrackerUIForms
{
    partial class FrmTournamentDario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTournamentDario));
            this.LblHeader = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchupListbox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.LblVersus = new System.Windows.Forms.Label();
            this.BtnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHeader.Location = new System.Drawing.Point(15, 11);
            this.LblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(229, 42);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.Location = new System.Drawing.Point(237, 11);
            this.tournamentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(152, 42);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<None>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(133, 86);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(260, 45);
            this.RoundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(133, 137);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(205, 41);
            this.UnplayedOnlyCheckBox.TabIndex = 4;
            this.UnplayedOnlyCheckBox.Text = "Unplayed only";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchupListbox
            // 
            this.MatchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListbox.FormattingEnabled = true;
            this.MatchupListbox.ItemHeight = 37;
            this.MatchupListbox.Location = new System.Drawing.Point(32, 210);
            this.MatchupListbox.Name = "MatchupListbox";
            this.MatchupListbox.Size = new System.Drawing.Size(361, 298);
            this.MatchupListbox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneName.Location = new System.Drawing.Point(434, 210);
            this.TeamOneName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(167, 37);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<Team one>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(434, 263);
            this.TeamOneScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(523, 257);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(100, 43);
            this.TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(523, 419);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(100, 43);
            this.TeamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(434, 425);
            this.TeamTwoScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.TeamTwoScoreLabel.TabIndex = 10;
            this.TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoName.Location = new System.Drawing.Point(434, 372);
            this.TeamTwoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(167, 37);
            this.TeamTwoName.TabIndex = 9;
            this.TeamTwoName.Text = "<Team two>";
            // 
            // LblVersus
            // 
            this.LblVersus.AutoSize = true;
            this.LblVersus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVersus.Location = new System.Drawing.Point(519, 323);
            this.LblVersus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVersus.Name = "LblVersus";
            this.LblVersus.Size = new System.Drawing.Size(84, 37);
            this.LblVersus.TabIndex = 12;
            this.LblVersus.Text = "- VS -";
            // 
            // BtnScore
            // 
            this.BtnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnScore.Location = new System.Drawing.Point(650, 317);
            this.BtnScore.Name = "BtnScore";
            this.BtnScore.Size = new System.Drawing.Size(99, 48);
            this.BtnScore.TabIndex = 13;
            this.BtnScore.Text = "&Score";
            this.BtnScore.UseVisualStyleBackColor = true;
            // 
            // FrmTournamentDario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 573);
            this.Controls.Add(this.BtnScore);
            this.Controls.Add(this.LblVersus);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchupListbox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.LblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmTournamentDario";
            this.Text = "Tournament viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblHeader;
        private Label tournamentName;
        private Label label1;
        private ComboBox RoundDropDown;
        private CheckBox UnplayedOnlyCheckBox;
        private ListBox MatchupListbox;
        private Label TeamOneName;
        private Label TeamOneScoreLabel;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreValue;
        private Label TeamTwoScoreLabel;
        private Label TeamTwoName;
        private Label LblVersus;
        private Button BtnScore;
    }
}