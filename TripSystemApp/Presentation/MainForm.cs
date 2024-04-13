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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            // Open the booking form
            var bookingForm = new BookingForm();
            bookingForm.ShowDialog();
        }

        private void btnTripPlanner_Click_1(object sender, EventArgs e)
        {
            // Open the trip planner form
            var tripPlannerForm = new TripPlannerForm();
            tripPlannerForm.ShowDialog();
        }
    }
}
