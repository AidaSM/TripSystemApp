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
            // Search for the DestinationID based on the destination name
            Destination destination = _context.Destinations.FirstOrDefault(d => d.City+", "+d.Country == destinationName);

            if (destination != null)
            {
                // If a destination with the given name is found, return its ID
                return destination.DestinationId;
            }
            else
            {
                // If the destination is not found, return a default value or throw an exception
                // You can decide how you want to handle this case based on your application's requirements
                return 0; // Return 0 as a default value
            }
        }
    }
}
