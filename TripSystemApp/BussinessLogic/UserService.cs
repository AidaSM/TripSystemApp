using System;
using System.Security.Cryptography;
using TripSystemApp.DataAccess;
using TripSystemApp.Models;

namespace TripSystemApp.BusinessLogic
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Register a new user
        public void RegisterUser(User user)
        {
            // Hash the password before storing it
            string hashedPassword = HashPassword(user.Password);

            // Create a new User object
            User newUser = new User
            {
                Username = user.Username,
                Password = hashedPassword,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            // Add the new user to the repository
            _userRepository.Add(newUser);
        }

        // Authenticate user by username and password
        public bool AuthenticateUser(string email, string password)
        {
            User user = _userRepository.GetUserByEmail(email);

            if (user != null)
            {
                // Check if the provided password matches the hashed password stored in the database
                if (VerifyPassword(password, user.Password))
                {
                    return true; // Authentication successful
                }
            }
            return false; // Authentication failed
        }

        // Hash the password using a cryptographic hashing algorithm
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        // Verify if the provided password matches the hashed password
        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }
    }
}
