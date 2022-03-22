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
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchup = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            RoundDropDown.DataSource = rounds;
            MatchupListbox.DataSource = selectedMatchup;
            MatchupListbox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach(List<MatchupModel> matchups in tournament.Rounds)
            {
                if(matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            LoadMatchups(1);
        }

        private void RoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchup.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !UnplayedOnlyCheckBox.Checked)
                        {
                            selectedMatchup.Add(m);
                        } 
                    }
                }
            }
            if (selectedMatchup.Count > 0) 
            {
                LoadMatchup(selectedMatchup.First());
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = selectedMatchup.Count > 0;

            TeamOneName.Visible = isVisible;
            TeamOneScoreLabel.Visible = isVisible;
            TeamOneScoreValue.Visible = isVisible;
            TeamTwoName.Visible = isVisible;
            TeamTwoScoreLabel.Visible = isVisible;
            TeamTwoScoreValue.Visible = isVisible;
            LblVersus.Visible = isVisible;
            BtnScore.Visible = isVisible;
        }

        private void LoadMatchup(MatchupModel m)
        {
            for(int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if(m.Entries[0].TeamCompeting != null)
                    {
                        TeamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        TeamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        TeamTwoName.Text = "<bye>";
                        TeamTwoScoreValue.Text = "";
                    }
                    else
                    {
                        TeamOneName.Text = "Not yet set";
                        TeamOneScoreValue.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        TeamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        TeamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        TeamTwoName.Text = "Not yet set";
                        TeamTwoScoreValue.Text = "";
                    }
                }
            }
        }

        private void MatchupListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MatchupListbox.SelectedIndex != -1)
            {
                LoadMatchup((MatchupModel)MatchupListbox.SelectedItem);
            }
        }

        private void UnplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);
        }

        private bool IsValidData()
        {
            bool output = true;

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(TeamOneScoreValue.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(TeamTwoScoreValue.Text, out teamTwoScore);

            if (!scoreOneValid || !scoreTwoValid)
            {
                output = false;
            }

            if(teamOneScore == 0 && teamTwoScore == 0)
            {
                return false;
            }

            if(teamOneScore == teamTwoScore)
            {
                output = false;
            }

            return output;
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
            {
                MessageBox.Show("You need to enter valid data before we can score this matchup.");
                return;
            }
            MatchupModel m = (MatchupModel)MatchupListbox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(TeamOneScoreValue.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(TeamTwoScoreValue.Text, out teamTwoScore);
                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 2.");
                            return;
                        }
                    }
                }
            }
            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application had the following error: {ex.Message}");
            }

            LoadMatchups((int)RoundDropDown.SelectedItem);
        }
    }
}
