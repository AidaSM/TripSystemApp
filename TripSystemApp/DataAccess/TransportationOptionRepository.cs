// TransportationOptionRepository.cs
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class TransportationOptionRepository : GenericRepository<TransportationOption>
    {
        public TransportationOptionRepository(TravelDbContext context) : base(context)
        {
        }
    }
}