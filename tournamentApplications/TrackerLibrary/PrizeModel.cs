using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the number of whitch place there is in the current tournament.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents of what the placenumbers should be called by name.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the value of a prize of the current tournament in numbers.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the value of a prize of the current tournament in percent.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
