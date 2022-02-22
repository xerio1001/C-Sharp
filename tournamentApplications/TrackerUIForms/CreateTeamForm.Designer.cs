namespace TrackerUIForms
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.LblTeamName = new System.Windows.Forms.Label();
            this.Lbltitle = new System.Windows.Forms.Label();
            this.BtnAddMember = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.LblSelectTeamMember = new System.Windows.Forms.Label();
            this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
            this.BtnCreateMember = new System.Windows.Forms.Button();
            this.PhoneNumberValue = new System.Windows.Forms.TextBox();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.BtnDeleteSelectedMember = new System.Windows.Forms.Button();
            this.BtnCreateTeam = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameValue.Location = new System.Drawing.Point(45, 123);
            this.TeamNameValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(468, 36);
            this.TeamNameValue.TabIndex = 32;
            // 
            // LblTeamName
            // 
            this.LblTeamName.AutoSize = true;
            this.LblTeamName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LblTeamName.Location = new System.Drawing.Point(188, 81);
            this.LblTeamName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTeamName.Name = "LblTeamName";
            this.LblTeamName.Size = new System.Drawing.Size(157, 37);
            this.LblTeamName.TabIndex = 31;
            this.LblTeamName.Text = "Team Name";
            // 
            // Lbltitle
            // 
            this.Lbltitle.AutoSize = true;
            this.Lbltitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Lbltitle.Location = new System.Drawing.Point(27, -72);
            this.Lbltitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbltitle.Name = "Lbltitle";
            this.Lbltitle.Size = new System.Drawing.Size(240, 37);
            this.Lbltitle.TabIndex = 30;
            this.Lbltitle.Text = "Create tournament";
            // 
            // BtnAddMember
            // 
            this.BtnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddMember.Location = new System.Drawing.Point(188, 289);
            this.BtnAddMember.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddMember.Name = "BtnAddMember";
            this.BtnAddMember.Size = new System.Drawing.Size(170, 44);
            this.BtnAddMember.TabIndex = 36;
            this.BtnAddMember.Text = "Add Member";
            this.BtnAddMember.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(127, 241);
            this.SelectTeamMemberDropDown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(289, 38);
            this.SelectTeamMemberDropDown.TabIndex = 35;
            // 
            // LblSelectTeamMember
            // 
            this.LblSelectTeamMember.AutoSize = true;
            this.LblSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSelectTeamMember.Location = new System.Drawing.Point(162, 205);
            this.LblSelectTeamMember.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSelectTeamMember.Name = "LblSelectTeamMember";
            this.LblSelectTeamMember.Size = new System.Drawing.Size(219, 30);
            this.LblSelectTeamMember.TabIndex = 34;
            this.LblSelectTeamMember.Text = "Select Team Member";
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.BtnCreateMember);
            this.AddNewMemberBox.Controls.Add(this.PhoneNumberValue);
            this.AddNewMemberBox.Controls.Add(this.LblPhoneNumber);
            this.AddNewMemberBox.Controls.Add(this.EmailValue);
            this.AddNewMemberBox.Controls.Add(this.LblEmail);
            this.AddNewMemberBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberBox.Controls.Add(this.LblLastName);
            this.AddNewMemberBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberBox.Controls.Add(this.LblFirstName);
            this.AddNewMemberBox.Location = new System.Drawing.Point(45, 392);
            this.AddNewMemberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddNewMemberBox.Size = new System.Drawing.Size(468, 273);
            this.AddNewMemberBox.TabIndex = 37;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add new member";
            // 
            // BtnCreateMember
            // 
            this.BtnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateMember.Location = new System.Drawing.Point(143, 213);
            this.BtnCreateMember.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnCreateMember.Name = "BtnCreateMember";
            this.BtnCreateMember.Size = new System.Drawing.Size(181, 44);
            this.BtnCreateMember.TabIndex = 38;
            this.BtnCreateMember.Text = "Create Member";
            this.BtnCreateMember.UseVisualStyleBackColor = true;
            this.BtnCreateMember.Click += new System.EventHandler(this.BtnCreateMember_Click);
            // 
            // PhoneNumberValue
            // 
            this.PhoneNumberValue.Location = new System.Drawing.Point(163, 167);
            this.PhoneNumberValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneNumberValue.Name = "PhoneNumberValue";
            this.PhoneNumberValue.Size = new System.Drawing.Size(271, 36);
            this.PhoneNumberValue.TabIndex = 45;
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPhoneNumber.Location = new System.Drawing.Point(6, 170);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(156, 30);
            this.LblPhoneNumber.TabIndex = 44;
            this.LblPhoneNumber.Text = "Phone number";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(163, 123);
            this.EmailValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(271, 36);
            this.EmailValue.TabIndex = 43;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.Location = new System.Drawing.Point(91, 129);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(64, 30);
            this.LblEmail.TabIndex = 42;
            this.LblEmail.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(163, 78);
            this.LastNameValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(271, 36);
            this.LastNameValue.TabIndex = 41;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLastName.Location = new System.Drawing.Point(45, 84);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(110, 30);
            this.LblLastName.TabIndex = 40;
            this.LblLastName.Text = "Last name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(163, 34);
            this.FirstNameValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(271, 36);
            this.FirstNameValue.TabIndex = 39;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFirstName.Location = new System.Drawing.Point(42, 40);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(113, 30);
            this.LblFirstName.TabIndex = 38;
            this.LblFirstName.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "Create Team";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 30;
            this.TeamMembersListBox.Location = new System.Drawing.Point(579, 123);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(359, 542);
            this.TeamMembersListBox.TabIndex = 38;
            // 
            // BtnDeleteSelectedMember
            // 
            this.BtnDeleteSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteSelectedMember.Location = new System.Drawing.Point(955, 358);
            this.BtnDeleteSelectedMember.Name = "BtnDeleteSelectedMember";
            this.BtnDeleteSelectedMember.Size = new System.Drawing.Size(126, 73);
            this.BtnDeleteSelectedMember.TabIndex = 39;
            this.BtnDeleteSelectedMember.Text = "Delete selected";
            this.BtnDeleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // BtnCreateTeam
            // 
            this.BtnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateTeam.Location = new System.Drawing.Point(457, 708);
            this.BtnCreateTeam.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnCreateTeam.Name = "BtnCreateTeam";
            this.BtnCreateTeam.Size = new System.Drawing.Size(181, 44);
            this.BtnCreateTeam.TabIndex = 40;
            this.BtnCreateTeam.Text = "Create Team";
            this.BtnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 776);
            this.Controls.Add(this.BtnCreateTeam);
            this.Controls.Add(this.BtnDeleteSelectedMember);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMemberBox);
            this.Controls.Add(this.BtnAddMember);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.LblSelectTeamMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.LblTeamName);
            this.Controls.Add(this.Lbltitle);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.AddNewMemberBox.ResumeLayout(false);
            this.AddNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TeamNameValue;
        private Label LblTeamName;
        private Label Lbltitle;
        private Button BtnAddMember;
        private ComboBox SelectTeamMemberDropDown;
        private Label LblSelectTeamMember;
        private GroupBox AddNewMemberBox;
        private TextBox FirstNameValue;
        private Label LblFirstName;
        private TextBox LastNameValue;
        private Label LblLastName;
        private TextBox EmailValue;
        private Label LblEmail;
        private TextBox PhoneNumberValue;
        private Label LblPhoneNumber;
        private Label label1;
        private Button BtnCreateMember;
        private ListBox TeamMembersListBox;
        private Button BtnDeleteSelectedMember;
        private Button BtnCreateTeam;
    }
}