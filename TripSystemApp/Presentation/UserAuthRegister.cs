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
            string username = txtRegUsername.Text;
            string password1 = txtRegPass1.Text;
            string password2 = txtRegPass2.Text;
            string email = txtRegEmail.Text;
            string firstName = txtRegFirstName.Text;
            string lastName = txtRegLastName.Text;

            if (password1 != password2)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                User newUser = new User
                {
                    Username = username,
                    Password = password1,
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName
                };

            try
            {
                _userService.RegisterUser(newUser);

                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
