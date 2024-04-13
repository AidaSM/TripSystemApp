using System.Data.Entity;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class TravelDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<TransportationOption> TransportationOptions { get; set; }
        public DbSet<UserTrip> UserTrips { get; set; }
        public DbSet<TripAccommodation> TripAccommodations { get; set; }
        public DbSet<TripTransportation> TripTransportations { get; set; }

        // Constructor
        public TravelDbContext() : base("name=TravelDbConnectionString")
        {
        }
    }
}
