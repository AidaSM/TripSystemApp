using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.DataAccess;
using TripSystemApp.Models;

namespace TripSystemApp.BussinessLogic
{
    internal class TripAccommodationService
    {
        private readonly TripAccommodationRepository _accommodationRepository;
        private readonly AccommodationRepository _accommRepository;

        public TripAccommodationService(TripAccommodationRepository accommodationRepository)
        {
            _accommodationRepository = accommodationRepository;
        }
        public TripAccommodationService(AccommodationRepository accommodationRepository)
        {
            _accommRepository = accommodationRepository;
        }
        public List<Accommodation> SearchAccommodations(string destination, string accommodationType)
        {
            // Query accommodations based on destination, check-in, and check-out dates
            // Example: Retrieve accommodations that match the destination and have availability between check-in and check-out dates
            return _accommRepository.GetAccommodationsByDestinationAndType(destination, accommodationType);
        }

        public List<TripAccommodation> GetAccommodationsByUserTripID(int userTripID)
        {
            // Retrieve accommodations associated with the specified user trip ID
            return _accommodationRepository.GetAccommodationsByUserTripID(userTripID);
        }
    }
}
