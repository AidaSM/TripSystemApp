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
    }
}
