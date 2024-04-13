using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripSystemApp.DataAccess;
using TripSystemApp.Models;

namespace TripSystemApp.Presentation
{
    public partial class AccomodationForm : Form
    {
        private readonly TravelDbContext _dbContext;
        private readonly AccommodationRepository _accommodationRepository;

        public AccomodationForm()
        {
            InitializeComponent();

             _dbContext = new TravelDbContext();
            // Instantiate the AccommodationRepository using the DbContext
            _accommodationRepository = new AccommodationRepository(_dbContext);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input values from the form
            string name = txtName.Text;
            string description = txtDescription.Text;
            string type = txtType.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            string location = txtLocation.Text;
            int destinationId = Convert.ToInt32(txtDestinationId.Text); // Assuming destination ID is entered by the user

            // Create a new Accommodation object
            Accommodation newAccommodation = new Accommodation
            {
                Name = name,
                Description = description,
                Type = type,
                Price = price,
                Location = location,
                DestinationID = destinationId
            };

            // Add the new accommodation to the database
            _accommodationRepository.Add(newAccommodation);

            // Show success message
            MessageBox.Show("Accommodation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form fields
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtType.Text = "";
            txtPrice.Text = "";
            txtLocation.Text = "";
            txtDestinationId.Text = "";
        }
    }
}
