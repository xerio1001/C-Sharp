using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents all current stats of the teams in the current tournament.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The Id from the database that will be used to identify the winner.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// Represents the winning team of the current tournament.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// represents the active round of the current tournament.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";

                foreach(MatchupEntryModel me in Entries)
                {
                    if (output.Length == 0)
                    {
                        output = me.TeamCompeting.TeamName;
                    }
                    else
                    {
                        output += $" vs. {me.TeamCompeting.TeamName}";
                    }
                }

                return output;
            }
        }
    }
}
