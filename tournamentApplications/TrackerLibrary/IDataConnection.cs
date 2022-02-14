using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    // TODO - Make the CreatePrize method to actually save to the database
    /// <summary>
    /// Saves a new prize to the database
    /// </summary>
    /// <param name="model">The prize information</param>
    /// <returns>The prize information, including the unique identifier.</returns>
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
