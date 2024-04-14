using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.Models;

namespace TripSystemApp.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByEmail(string email);
        User GetUserByUsername(string username);
    }
}
