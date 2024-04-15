using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class AccommodationRepository : GenericRepository<Accommodation>
    {
        public AccommodationRepository(TravelDbContext context) : base(context)
        {
        }
        public List<Accommodation> GetAccommodationsByDestinationAndType(string destination, string accommodationType)
        {
            return _context.Accommodations
                .Where(a => a.Location.ToLower() == destination.ToLower() && a.Type.ToLower() == accommodationType.ToLower())
                .ToList();
        }
    }
}
