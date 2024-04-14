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
using TripSystemApp.BussinessLogic;
using TripSystemApp.DataAccess;
using TripSystemApp.Models;

namespace TripSystemApp.Presentation
{
    public partial class TripPlannerForm: Form
    {
        private readonly UserService _userService;
        private readonly TripAccommodationService _tripAccommodationService;
        private readonly TripTransportationService _tripTransportationService;
        private User _currentUser;
        private readonly TravelDbContext _dbContext;
        private UserRepository userRepository;
        public TripPlannerForm(User currentUser)
        {
            _dbContext = new TravelDbContext();
            // Instantiate the UserRepository and UserTripRepository using the DbContext
            userRepository = new UserRepository(_dbContext);
            var userTripRepository = new UserTripRepository(_dbContext);
            var userTripOptionRepository = new TransportationOptionRepository(_dbContext);
            var accommodationRepository = new AccommodationRepository(_dbContext);

            _userService = new UserService(userRepository, userTripRepository); // Initialize your UserService
            _tripTransportationService = new TripTransportationService(userTripOptionRepository);
            _tripAccommodationService = new TripAccommodationService(accommodationRepository);

            InitializeComponent();
            dtpDepartureDate.Format = DateTimePickerFormat.Custom;
            dtpDepartureDate.CustomFormat = "dd/MM/yyyy HH:mm";

            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.CustomFormat = "dd/MM/yyyy HH:mm";

            tabPage1.Controls.Add(dtpDepartureDate);
            tabPage3.Controls.Add(dtpReturnDate);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Retrieve user input from the form
            string destination = txtDestination.Text;
            string departure = txtDeparture.Text;
            DateTime departureDate = dtpDepartureDate.Value.Date;
            string transportType = cmbTransportType.SelectedItem?.ToString();

            // Retrieve available transportations based on the destination and departure date
            List<TransportationOption> transportations = _tripTransportationService.GetTransportationsByDestinationAndTime(destination, departureDate, transportType);

            if (dataGridViewSearchResults.Columns.Contains("TransportationID"))
            {
                dataGridViewSearchResults.Columns.Remove("TransportationID");
            }

            dataGridViewSearchResults.DataSource = transportations;
        }

  

        private void btnChoose_Click(object sender, EventArgs e)
        {
            int nextTabIndex = tabControlMain.SelectedIndex + 1;
            if (nextTabIndex < tabControlMain.TabCount)
            {
                tabControlMain.SelectedIndex = nextTabIndex;
            }
        }


        private void btnSearchReturn_Click(object sender, EventArgs e)
        {
            string destination = txtDestination.Text;
            string accommodationType = cmbAccommodationType.SelectedItem?.ToString();

            // Query the database to find matching accommodations based on the user input
            List<Accommodation> accommodations = _tripAccommodationService.SearchAccommodations(destination, accommodationType);
            if (dataGridViewSearchResults.Columns.Contains("AccommodationID"))
            {
                dataGridViewSearchResults.Columns.Remove("AccommodationID");
            }
            if (dataGridViewSearchResults.Columns.Contains("DestinationID"))
            {
                dataGridViewSearchResults.Columns.Remove("DestinationID");
            }
            // Display the search results in a DataGridView or another appropriate control
            dataGridViewAccommodations.DataSource = accommodations;
        }
    }
}
