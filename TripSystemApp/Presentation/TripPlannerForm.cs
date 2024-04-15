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
        private readonly DestinationRepository _destinationRepository;
        private User _currentUser;

        private string selectedDeparture;
        private string selectedAccommodation;
        private string selectedReturn;
        public TripPlannerForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            var dbContext = new TravelDbContext();

            var userRepository = new UserRepository(dbContext);
            var userTripRepository = new UserTripRepository(dbContext);
            var userTripOptionRepository = new TransportationOptionRepository(dbContext);
            var accommodationRepository = new AccommodationRepository(dbContext);

            _userService = new UserService(userRepository, userTripRepository);
            _tripTransportationService = new TripTransportationService(dbContext, userTripOptionRepository);
            _tripAccommodationService = new TripAccommodationService(dbContext, accommodationRepository);
            _destinationRepository = new DestinationRepository(dbContext);

            InitializeDateTimePickers();
        }
        private void InitializeDateTimePickers()
        {
            dtpDepartureDate.Format = DateTimePickerFormat.Custom;
            dtpDepartureDate.CustomFormat = "dd/MM/yyyy HH:mm";

            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.CustomFormat = "dd/MM/yyyy HH:mm";

            tabPage1.Controls.Add(dtpDepartureDate);
            tabPage3.Controls.Add(dtpReturnDate);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string destination = txtDestination.Text;
            DateTime departureDate = dtpDepartureDate.Value.Date;
            string transportType = cmbTransportType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Please enter a destination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<TransportationOption> transportations = _tripTransportationService.GetTransportationsByDestinationAndTime(destination, departureDate, transportType);
            dataGridViewSearchResults.DataSource = transportations;

            dataGridViewSearchResults.Columns["TransportationID"].Visible = false;
           
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

            List<Accommodation> accommodations = _tripAccommodationService.SearchAccommodations(destination, accommodationType);

            dataGridViewAccommodations.DataSource = accommodations;
            dataGridViewAccommodations.Columns["AccommodationID"].Visible = false;
            dataGridViewAccommodations.Columns["DestinationID"].Visible = false;
            
        }

        private void btnSearchReturn_Click_1(object sender, EventArgs e)
        {
                string departure = txtDeparture.Text;
                DateTime returnDate = dtpReturnDate.Value.Date;
                string transportType = cmbTransportTypeReturn.SelectedItem?.ToString();

                List<TransportationOption> transportations = _tripTransportationService.GetTransportationsByDestinationAndTime(departure, returnDate, transportType);

                dataGridViewReturn.DataSource = transportations;
                dataGridViewReturn.Columns["TransportationID"].Visible = false;

        }

        private void btnChooseAccomm_Click(object sender, EventArgs e)
        {
            int nextTabIndex = tabControlMain.SelectedIndex + 1;
            if (nextTabIndex < tabControlMain.TabCount)
            {
                tabControlMain.SelectedIndex = nextTabIndex;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            int nextTabIndex = tabControlMain.SelectedIndex + 1;
            if (nextTabIndex < tabControlMain.TabCount)
            {
                tabControlMain.SelectedIndex = nextTabIndex;
            }
        }



        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPage4)
            {
                lblDestination.Text = txtDestination.Text;
                lblDeparture.Text = txtDeparture.Text;

                decimal totalCost = 0;
                DateTime departureDate = DateTime.MinValue;
                DateTime returnDate = DateTime.MinValue;

                if (!string.IsNullOrEmpty(selectedDeparture))
                {
                    TransportationOption departureTransportation = _tripTransportationService.GetTransportationById(selectedDeparture);
                    lblTransportTypeDeparture.Text = departureTransportation.Type;
                    lblStartDate.Text = departureTransportation.DepartureTime.ToString();

                    totalCost += departureTransportation.Price;

                    departureDate = departureTransportation.DepartureTime;
                }

                if (!string.IsNullOrEmpty(selectedAccommodation))
                {
                    Accommodation accommodation = _tripAccommodationService.GetAccommodationById(selectedAccommodation);
                    lblAccommodation.Text = accommodation.Name;

                    TimeSpan accommodationDuration = returnDate - departureDate;
                    int numberOfNights = (int)Math.Ceiling(accommodationDuration.TotalDays);

                    totalCost += accommodation.Price * numberOfNights;
                }

                if (!string.IsNullOrEmpty(selectedReturn))
                {
                    TransportationOption returnTransportation = _tripTransportationService.GetTransportationById(selectedReturn);
                    lblTransportTypeReturn.Text = returnTransportation.Type;
                    lblReturnDate.Text = returnTransportation.DepartureTime.ToString(); 

                    totalCost += returnTransportation.Price;

                    returnDate = returnTransportation.DepartureTime;
                }

                lblTotalCost.Text = totalCost.ToString("C"); 
            }
        }


        private void dataGridViewSearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedDeparture = dataGridViewSearchResults.Rows[e.RowIndex].Cells["TransportationID"].Value.ToString();
            }
        }

        private void dataGridViewReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedReturn = dataGridViewReturn.Rows[e.RowIndex].Cells["TransportationID"].Value.ToString();
            }
        }

        private void dataGridViewAccommodations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedAccommodation = dataGridViewAccommodations.Rows[e.RowIndex].Cells["AccommodationID"].Value.ToString();
            }
        }

        private void btnBookTrip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedDeparture) || string.IsNullOrEmpty(selectedAccommodation) || string.IsNullOrEmpty(selectedReturn))
            {
                MessageBox.Show("Please select a departure transportation, accommodation, and return transportation before booking the trip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string destination = txtDestination.Text;
            string accommodationId = selectedAccommodation;
            string departureTransportationId = selectedDeparture;
            string returnTransportationId = selectedReturn;
            int userID = _currentUser.UserID;
            int destinationID = _destinationRepository.GetDestinationIDByName(destination);

            TransportationOption returnTransportation = _tripTransportationService.GetTransportationById(selectedReturn);
            DateTime returnDate = returnTransportation.DepartureTime;
            DateTime arrivalReturnDate = returnTransportation.ArrivalTime;

            TransportationOption departureTransportation = _tripTransportationService.GetTransportationById(selectedReturn);
            DateTime departureDate = departureTransportation.DepartureTime;
            DateTime arrivalDate = departureTransportation.ArrivalTime;

            int userTripId = _userService.CreateUserTrip(userID, destinationID, departureDate, returnDate);

            _tripAccommodationService.CreateTripAccommodation(userTripId, Int32.Parse(accommodationId), arrivalDate, returnDate);

            _tripTransportationService.CreateTripTransportation(userTripId, Int32.Parse(departureTransportationId), departureDate, arrivalDate);

            _tripTransportationService.CreateTripTransportation(userTripId, Int32.Parse(returnTransportationId), returnDate, arrivalReturnDate);

            MessageBox.Show("Trip booked successfully!");
        }

        
    }
}
