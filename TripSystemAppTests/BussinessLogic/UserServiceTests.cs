using Microsoft.VisualStudio.TestTools.UnitTesting;
using TripSystemApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.DataAccess;
using TripSystemApp.Models;
using Moq;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using TripSystemApp.Interfaces;

namespace TripSystemApp.BusinessLogic.Tests
{
    [TestClass()]
    public class UserServiceTests
    {
        private UserService _userService;
        private Mock<IUserRepository> _mockUserRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize mock repositories
            var mockUserRepository = new Mock<IUserRepository>();
            var mockUserTripRepository = new Mock<IUserTripRepository>();

            // Initialize UserService with mock repositories
            _userService = new UserService(mockUserRepository.Object, mockUserTripRepository.Object);
        }



        [TestMethod]
        public void RegisterUser_ValidUser_SuccessfullyRegistersUser()
        {
            // Arrange
            var user = new User
            {
                Username = "newUser",
                Password = "password",
                Email = "user@example.com",
                FirstName = "John",
                LastName = "Doe"
            };

            // Act
            _userService.RegisterUser(user);

            // Assert
            _mockUserRepository.Verify(repo => repo.Add(It.Is<User>(u =>
                u.Username == user.Username &&
                u.Password != user.Password && // Password should be hashed
                u.Email == user.Email &&
                u.FirstName == user.FirstName &&
                u.LastName == user.LastName)), Times.Once);
        }

        [TestMethod]
        public void RegisterUser_NullUser_ThrowsArgumentNullException()
        {
            // Arrange
            User nullUser = null;

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => _userService.RegisterUser(nullUser));
        }
        [TestMethod]
        public void AuthenticateUser_ValidCredentials_ReturnsTrue()
        {
            var mockUserRepository = new Mock<IUserRepository>();
            var mockUserTripRepository = new Mock<IUserTripRepository>();

            mockUserRepository.Setup(m => m.GetUserByEmail("valid_email"))
                .Returns(new User { Email = "valid_email", Password = "hashed_password" });

            var userService = new UserService(mockUserRepository.Object, mockUserTripRepository.Object);

            bool result = userService.AuthenticateUser("valid_email", "hashed_password");

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void AuthenticateUser_InvalidPassword_ReturnsFalse()
        {
            var mockUserRepository = new Mock<IUserRepository>();
            var mockUserTripRepository = new Mock<IUserTripRepository>();

            
            // Simulate user retrieval with valid credentials
            mockUserRepository.Setup(m => m.GetUserByEmail("valid_email"))
                 .Returns(new User { Email = "valid_email", Password = "hashed_password" }); // Mock user with valid credentials

            var userService = new UserService(mockUserRepository.Object, mockUserTripRepository.Object);

            // Act
            bool result = userService.AuthenticateUser("valid_email", "wrong_password"); // Invalid password

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AuthenticateUser_NonExistentUser_ReturnsFalse()
        {
            var mockUserRepository = new Mock<IUserRepository>();
            var mockUserTripRepository = new Mock<IUserTripRepository>();

            // Simulate no user found for this email
            mockUserRepository.Setup(m => m.GetUserByEmail("valid_email"))
                 .Returns(new User { Email = "valid_email", Password = "hashed_password" }); // Mock user with valid credentials


            var userService = new UserService(mockUserRepository.Object, mockUserTripRepository.Object);

            // Act
            bool result = userService.AuthenticateUser("non_existent_email", "any_password"); // Non-existent user

            // Assert
            Assert.IsFalse(result);
        }

    }
}