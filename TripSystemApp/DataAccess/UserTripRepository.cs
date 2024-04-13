// UserTripRepository.cs
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class UserTripRepository : GenericRepository<UserTrip>
    {
        public UserTripRepository(TravelDbContext context) : base(context)
        {
        }
    }
}