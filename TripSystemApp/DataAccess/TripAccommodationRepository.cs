// TripAccommodationRepository.cs
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class TripAccommodationRepository : GenericRepository<TripAccommodation>
    {
        public TripAccommodationRepository(TravelDbContext context) : base(context)
        {
        }
        public List<TripAccommodation> GetAccommodationsByUserTripID(int userTripID)
        {
            // Retrieve accommodations associated with the specified user trip ID
            return _context.TripAccommodations
                           .Where(ta => ta.UserTripID == userTripID)
                           .ToList();
        }
    }
}