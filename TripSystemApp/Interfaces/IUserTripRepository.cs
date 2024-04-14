using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.Models;

namespace TripSystemApp.Interfaces
{
    public interface IUserTripRepository : IRepository<UserTrip>
    {
        void Add(UserTrip userTrip);
        List<UserTrip> GetUserTripsByUserId(int userId);
        IEnumerable<int> GetUserTripIDs(int userId, int destinationId, DateTime departureDate);
        
    }
}
