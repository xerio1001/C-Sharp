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
        /// Represents all current stats of the teams in the current tournament.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winning team of the current tournament.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// represents the active round of the current tournament.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
