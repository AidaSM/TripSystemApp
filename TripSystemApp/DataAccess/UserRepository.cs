using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(TravelDbContext context) : base(context)
        {
        }
        public User GetUserByUsername(string username)
        {
            return _dbSet.FirstOrDefault(u => u.Username == username);
        }

        public User GetUserByEmail(string email)
        {
            return _dbSet.FirstOrDefault(u => u.Email == email);
        }
    }
}