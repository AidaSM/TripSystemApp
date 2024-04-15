using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using TripSystemApp.Interfaces;
using TripSystemApp.Models;

namespace TripSystemApp.BusinessLogic
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserTripRepository _userTripRepository;

        public UserService(IUserRepository userRepository, IUserTripRepository userTripRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _userTripRepository = userTripRepository ?? throw new ArgumentNullException(nameof(userTripRepository));
        }

        public void RegisterUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            string hashedPassword = HashPassword(user.Password);

            User newUser = new User
            {
                Username = user.Username,
                Password = hashedPassword,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            _userRepository.Add(newUser);
        }

        public bool AuthenticateUser(string email, string password)
        {
            User user = _userRepository.GetUserByEmail(email);

            if (user != null)
            {
                return user.Password == HashPassword(password);
            }
            else
            {
                return false;
            }
        }

        public List<UserTrip> GetUserTrips(int userId)
        {
            return _userTripRepository.GetUserTripsByUserId(userId);
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        public IEnumerable<int> GetUserTripIDs(int userID, int destinationID, DateTime departureDate)
        {
            return _userTripRepository.GetUserTripIDs(userID, destinationID, departureDate);
        }

        public int CreateUserTrip(int userId, int destinationId, DateTime departureDate, DateTime returnDate)
        {
            UserTrip userTrip = new UserTrip
            {
                UserID = userId,
                DestinationID = destinationId,
                DepartureDate = departureDate,
                ReturnDate = returnDate
            };

            _userTripRepository.Add(userTrip);

            return userTrip.UserTripID;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }
    }
}
