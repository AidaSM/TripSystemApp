using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripSystemApp.Presentation
{
    public partial class TripPlannerForm : Form
    {
        public TripPlannerForm()
        {
            InitializeComponent();
        }


        private void TripPlannerForm_Load(object sender, EventArgs e)
        {
            // Initialize the form
            // You can add any initialization code here
        }

        private void btnSearchDestinations_Click(object sender, EventArgs e)
        {
            // Handle search destinations button click event
            // Open a new form or dialog for searching destinations
            // Example:
            // var searchDestinationsForm = new SearchDestinationsForm();
            // searchDestinationsForm.ShowDialog();
        }

        private void btnSearchAccommodations_Click(object sender, EventArgs e)
        {
            // Handle search accommodations button click event
            // Open a new form or dialog for searching accommodations
        }

        private void btnSearchTransportation_Click(object sender, EventArgs e)
        {
            // Handle search transportation button click event
            // Open a new form or dialog for searching transportation options
        }
    }
}
