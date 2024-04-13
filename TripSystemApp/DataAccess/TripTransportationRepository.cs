// TripTransportationRepository.cs
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
    }
}