using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the current tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee of the current tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents all the teams that entered the current tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents all the prizes that are winnable in the current tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents all the rounds that are in the current tournament. (Lists in List)
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
