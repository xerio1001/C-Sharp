using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUIForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new TournamentDashboardForm());
=======
            // initialize the database connections.
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            Application.Run(new CreateTeamForm());

            //Application.Run(new TournamentDashboardForm());
>>>>>>> f542e07445d998b4b9bd6ff1d9a3f5fe6b6eed27
        }
    }
}