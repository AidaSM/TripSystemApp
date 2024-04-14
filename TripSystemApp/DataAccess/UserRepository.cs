using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Interfaces;
using TripSystemApp.Models;

namespace TripSystemApp.DataAccess
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(TravelDbContext context) : base(context)
        {
        }
        public User GetUserByUsername(string username)
        {
            return _dbSet.FirstOrDefault(u => u.Username == username);
        }

        public virtual User GetUserByEmail(string email)
        {
            return _dbSet.FirstOrDefault(u => u.Email == email);
        }
    }
}