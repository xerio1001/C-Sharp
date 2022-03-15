namespace TrackerUIForms
{
    partial class TournamentViewerForm
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
            this.BtnScore = new System.Windows.Forms.Button();
            this.LblVersus = new System.Windows.Forms.Label();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.MatchupListbox = new System.Windows.Forms.ListBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnScore
            // 
            this.BtnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnScore.Location = new System.Drawing.Point(648, 315);
            this.BtnScore.Name = "BtnScore";
            this.BtnScore.Size = new System.Drawing.Size(99, 48);
            this.BtnScore.TabIndex = 27;
            this.BtnScore.Text = "&Score";
            this.BtnScore.UseVisualStyleBackColor = true;
            // 
            // LblVersus
            // 
            this.LblVersus.AutoSize = true;
            this.LblVersus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVersus.Location = new System.Drawing.Point(517, 321);
            this.LblVersus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVersus.Name = "LblVersus";
            this.LblVersus.Size = new System.Drawing.Size(84, 37);
            this.LblVersus.TabIndex = 26;
            this.LblVersus.Text = "- VS -";
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(521, 422);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(100, 43);
            this.TeamTwoScoreValue.TabIndex = 25;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(432, 423);
            this.TeamTwoScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.TeamTwoScoreLabel.TabIndex = 24;
            this.TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoName.Location = new System.Drawing.Point(432, 370);
            this.TeamTwoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(167, 37);
            this.TeamTwoName.TabIndex = 23;
            this.TeamTwoName.Text = "<Team two>";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreValue.Location = new System.Drawing.Point(521, 260);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(100, 43);
            this.TeamOneScoreValue.TabIndex = 22;
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(432, 261);
            this.TeamOneScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.TeamOneScoreLabel.TabIndex = 21;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneName.Location = new System.Drawing.Point(432, 208);
            this.TeamOneName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(167, 37);
            this.TeamOneName.TabIndex = 20;
            this.TeamOneName.Text = "<Team one>";
            // 
            // MatchupListbox
            // 
            this.MatchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListbox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatchupListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MatchupListbox.FormattingEnabled = true;
            this.MatchupListbox.ItemHeight = 37;
            this.MatchupListbox.Location = new System.Drawing.Point(30, 208);
            this.MatchupListbox.Name = "MatchupListbox";
            this.MatchupListbox.Size = new System.Drawing.Size(361, 298);
            this.MatchupListbox.TabIndex = 19;
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(131, 135);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(205, 41);
            this.UnplayedOnlyCheckBox.TabIndex = 18;
            this.UnplayedOnlyCheckBox.Text = "Unplayed only";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(131, 84);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(260, 45);
            this.RoundDropDown.TabIndex = 17;
            this.RoundDropDown.SelectedIndexChanged += new System.EventHandler(this.RoundDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Round";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.Location = new System.Drawing.Point(235, 9);
            this.tournamentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(152, 42);
            this.tournamentName.TabIndex = 15;
            this.tournamentName.Text = "<None>";
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHeader.Location = new System.Drawing.Point(13, 9);
            this.LblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(229, 42);
            this.LblHeader.TabIndex = 14;
            this.LblHeader.Text = "Tournament:";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 535);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnScore;
        private Label LblVersus;
        private TextBox TeamTwoScoreValue;
        private Label TeamTwoScoreLabel;
        private Label TeamTwoName;
        private TextBox TeamOneScoreValue;
        private Label TeamOneScoreLabel;
        private Label TeamOneName;
        private ListBox MatchupListbox;
        private CheckBox UnplayedOnlyCheckBox;
        private ComboBox RoundDropDown;
        private Label label1;
        private Label tournamentName;
        private Label LblHeader;
    }
}