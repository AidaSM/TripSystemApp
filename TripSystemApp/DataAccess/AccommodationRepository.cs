using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class AccommodationRepository
    {
        private readonly TravelDbContext _context;

        public AccommodationRepository(TravelDbContext context)
        {
            _context = context;
        }

        public void AddAccommodation(Accommodation accommodation)
        {
            _context.Accommodations.Add(accommodation);
            _context.SaveChanges();
        }

        // Implement other CRUD operations as needed
    }
}
