using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class UserRepository
    {
        private readonly TravelDbContext _context;

        public UserRepository(TravelDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        // Implement other CRUD operations as needed
    }
}
