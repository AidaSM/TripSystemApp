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

            // Create an instance of TravelDbContext
            TravelDbContext dbContext = new TravelDbContext(/* provide necessary parameters if any */);

            // Create an instance of UserTripRepository with the TravelDbContext instance
            UserTripRepository userTripRepository = new UserTripRepository(dbContext);

            // Create an instance of UserRepository with the TravelDbContext instance
            UserRepository userRepository = new UserRepository(dbContext);

            // Create an instance of UserService with the IUserRepository and IUserTripRepository instances
            UserService userService = new UserService(userRepository, userTripRepository);

            // Create an instance of UserAuthRegister and pass it the UserService instance
            Application.Run(new UserAuthRegister(userService));
        }



    }
}
