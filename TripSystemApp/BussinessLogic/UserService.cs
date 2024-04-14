using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Cryptography;
using TripSystemApp.DataAccess;
using TripSystemApp.Models;

namespace TripSystemApp.BusinessLogic
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly UserTripRepository _userTripRepository;
        private readonly TravelDbContext _dbContext;
        public UserService(TravelDbContext dbContext)
        {
            _dbContext = dbContext;
            _userRepository = new UserRepository(_dbContext);
            _userTripRepository = new UserTripRepository(_dbContext);
        }
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public UserService(UserTripRepository userTripRepository)
        {
            _userTripRepository = userTripRepository;
        }

        public UserService(UserRepository userRepository, UserTripRepository userTripRepository)
        {
            _userRepository = userRepository;
            _userTripRepository = userTripRepository;
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

        public List<UserTrip> GetUserTrips(int userId)
        {
            return _userTripRepository.GetUserTripsByUserId(userId);
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
        public User GetUserByEmail(string email)
        {
            // Retrieve the user based on their email
            return _userRepository.GetUserByEmail(email);
        }
        public IEnumerable<int> GetUserTripIDs(int userID, int destinationID, DateTime departureDate)
        {
            return _userTripRepository.GetUserTripIDs(userID, destinationID, departureDate);
        }

        // Verify if the provided password matches the hashed password
        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }
        public int CreateUserTrip(int userId, int destinationId, DateTime departureDate, DateTime returnDate)
        {
            // Create a new UserTrip object
            UserTrip userTrip = new UserTrip
            {
                UserID = userId, 
                DestinationID = destinationId,
                DepartureDate = departureDate,
                ReturnDate = returnDate
            };

            // Add the UserTrip to the database context
            _dbContext.UserTrips.Add(userTrip);

            // Save changes to the database
            _dbContext.SaveChanges();

            // Return the ID of the newly created UserTrip
            return userTrip.UserTripID;
        }
    }
}
