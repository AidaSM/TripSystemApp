// TripAccommodationRepository.cs
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class TripAccommodationRepository : GenericRepository<TripAccommodation>
    {
        public TripAccommodationRepository(TravelDbContext context) : base(context)
        {
        }
    }
}