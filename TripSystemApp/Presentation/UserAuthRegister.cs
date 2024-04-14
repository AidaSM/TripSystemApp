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

namespace TripSystemApp.Presentation
{
    public partial class UserAuthRegister : Form
    {
        private readonly UserService _userService;
        public UserAuthRegister(UserService userService)
        {
            InitializeComponent();
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtAuthEmail.Text;
            string password = txtAuthPass.Text;

            // Authenticate the user using the UserService
            bool isValidUser = _userService.AuthenticateUser(email, password);

            if (isValidUser)
            {
                User currentUser = _userService.GetUserByEmail(email);
                var mainForm = new MainForm(currentUser, _userService);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
                txtAuthPass.Clear();
            }
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            // Retrieve user input from the form
            string username = txtRegUsername.Text;
            string password1 = txtRegPass1.Text;
            string password2 = txtRegPass2.Text;
            string email = txtRegEmail.Text;
            string firstName = txtRegFirstName.Text;
            string lastName = txtRegLastName.Text;

            // Check if the passwords match
            if (password1 != password2)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method without proceeding further
            }
            // Create a new user object
            User newUser = new User
            {
                Username = username,
                Password = password1, // Remember to hash the password before saving it to the database
                Email = email,
                FirstName = firstName,
                LastName = lastName
            };

            try
            {
                // Add the new user to the database using the UserService
                _userService.RegisterUser(newUser);

                // Display a success message
                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display an error message if registration fails
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
