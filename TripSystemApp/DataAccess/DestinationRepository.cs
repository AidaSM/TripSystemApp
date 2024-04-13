using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class DestinationRepository
    {
        private readonly TravelDbContext _context;

        public DestinationRepository(TravelDbContext context)
        {
            _context = context;
        }

        public void AddDestination(Destination destination)
        {
            _context.Destinations.Add(destination);
            _context.SaveChanges();
        }

        // Implement other CRUD operations as needed
    }
}
