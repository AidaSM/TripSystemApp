using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class TravelDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<Trip> Trips { get; set; }

        // Constructor
        public TravelDbContext() : base("name=TravelDbConnectionString")
        {
        }
    }
}
