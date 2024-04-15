using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class TripTransportationRepository : GenericRepository<TripTransportation>
    {
        public TripTransportationRepository(TravelDbContext context) : base(context)
        {
        }
        public List<TripTransportation> GetTransportationsByUserTripID(int userTripID)
        {
            return _context.TripTransportations
                           .Where(tt => tt.UserTripID == userTripID)
                           .ToList();
        }
    }
}