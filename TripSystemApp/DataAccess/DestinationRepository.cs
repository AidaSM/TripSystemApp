using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class DestinationRepository : GenericRepository<Destination>
    {
        public DestinationRepository(TravelDbContext context) : base(context)
        {
        }
        public int GetDestinationIDByName(string destinationName)
        {
            Destination destination = _context.Destinations.FirstOrDefault(d => d.City+", "+d.Country == destinationName);

            if (destination != null)
            {
                return destination.DestinationId;
            }
            else
            {
                return 0;
            }
        }
    }
}
