// UserTripRepository.cs
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class UserTripRepository : GenericRepository<UserTrip>
    {
        public UserTripRepository(TravelDbContext context) : base(context)
        {
        }
        public List<UserTrip> GetUserTripsByUserId(int userId)
        {
            return _context.UserTrips
                           .Include(ut => ut.Destination) // Eager loading of Destination
                           .Where(ut => ut.UserID == userId)
                           .ToList();
        }
        public IEnumerable<int> GetUserTripIDs(int userID, int destinationID, DateTime departureDate)
        {
            return _context.UserTrips
                           .Where(ut => ut.UserID == userID &&
                                        ut.DestinationID == destinationID &&
                                        ut.DepartureDate == departureDate)
                           .Select(ut => ut.UserTripID)
                           .ToList();
        }
    }
}