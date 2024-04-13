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
    }
}
