using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUIForms
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData() 
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }

        private void WireUpLists()
        {
            SelectTeamMemberDropDown.DataSource = null;

            SelectTeamMemberDropDown.DataSource = availableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;

            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
        }

        private void BtnCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.EmailAddress = EmailValue.Text;
                p.PhoneNumber = PhoneNumberValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                PhoneNumberValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (EmailValue.Text.Length == 0)
            {
                return false;
            }

            if (PhoneNumberValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            //yt timestamp 9:05:30
            PersonModel p = (PersonModel)SelectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
            }

            WireUpLists();
        }

        private void BtnRemoveSelectedMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;
            if (p != null) {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }
    }
}
