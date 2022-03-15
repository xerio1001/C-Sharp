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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboardForm()
        {
            InitializeComponent();

            wireUpList();
        }

        private void wireUpList()
        {
            LoadExistingTournamentDropdown.DataSource = tournaments;
            LoadExistingTournamentDropdown.DisplayMember = "TournamentName";
        }

        private void BtnCreateTournament_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }

        private void BtnLoadTournament_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)LoadExistingTournamentDropdown.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }
    }
}
