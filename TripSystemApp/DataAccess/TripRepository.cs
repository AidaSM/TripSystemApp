using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class TripRepository
    {
        private readonly TravelDbContext _context;

        public TripRepository(TravelDbContext context)
        {
            _context = context;
        }

        public void AddTrip(Trip trip)
        {
            _context.Trips.Add(trip);
            _context.SaveChanges();
        }

        // Implement other CRUD operations as needed
    }
}
