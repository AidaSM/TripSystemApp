using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripSystemApp.BusinessLogic;
using TripSystemApp.DataAccess;
using TripSystemApp.Interfaces;
using TripSystemApp.Presentation;

namespace TripSystemApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TravelDbContext dbContext = new TravelDbContext();

            UserTripRepository userTripRepository = new UserTripRepository(dbContext);

            UserRepository userRepository = new UserRepository(dbContext);

            UserService userService = new UserService(userRepository, userTripRepository);

            Application.Run(new UserAuthRegister(userService));
        }



    }
}
