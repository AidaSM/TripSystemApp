using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripSystemApp.BusinessLogic;
using TripSystemApp.DataAccess;
using TripSystemApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TripSystemApp.Presentation
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;
        private User _currentUser;

        public MainForm(User currentUser, UserService userService)
        {
            InitializeComponent();

            _currentUser = currentUser; // Store the logged-in user
            _userService = userService; // Initialize your UserService

            // Set up DataGridView properties
            InitializeDataGridView();

            // Load the logged user's trips into the DataGridView
            LoadUserTrips();
            // Set the username label text
            SetUsernameLabel();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load the logged user's trips into the DataGridView
            LoadUserTrips();
            // Set the username label text
            SetUsernameLabel();
        }

        private void InitializeDataGridView()
        {
            // Set DataGridView properties
            dataGridViewTrips.AutoGenerateColumns = false;

            // Define columns for DataGridView
            dataGridViewTrips.Columns.Add("Destination", "Destination");
            dataGridViewTrips.Columns.Add("DepartureDate", "Departure Date");
            dataGridViewTrips.Columns.Add("ReturnDate", "Return Date");
        }

        private void LoadUserTrips()
        {
            // Retrieve the logged user's trips from the database
            var userTrips = _userService.GetUserTrips(_currentUser.UserID);

            // Bind the trips data to the DataGridView
            dataGridViewTrips.Rows.Clear();
            foreach (var trip in userTrips)
            {
                dataGridViewTrips.Rows.Add(trip.Destination.Name, trip.DepartureDate, trip.ReturnDate);
            }
        }

        private void SetUsernameLabel()
        {
            lblUsername.Text = $"Welcome, {_currentUser.Username}!";
        }
        private void btnOpenTripPlanner_Click(object sender, EventArgs e)
        {
            TripPlannerForm tripPlannerForm = new TripPlannerForm(_currentUser);

            // Show the TripPlannerForm
            tripPlannerForm.Show();
        }
    }
}
