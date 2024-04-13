using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class TransportationRepository
    {
        private readonly TravelDbContext _context;

        public TransportationRepository(TravelDbContext context)
        {
            _context = context;
        }

        public void AddTransportation(Transportation transportation)
        {
            _context.Transportations.Add(transportation);
            _context.SaveChanges();
        }

        // Implement other CRUD operations as needed
    }
}
