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
        private readonly TravelDbContext _dbContext;

    public TripAccommodationService(TravelDbContext dbContext, AccommodationRepository accommodationRepository)
    {
        _dbContext = dbContext;
        _accommRepository = accommodationRepository;
        }

    public void CreateTripAccommodation(int userTripId, int accommodationId, DateTime? checkInDate, DateTime? checkOutDate)
    {
        // Create a new TripAccommodation object
        TripAccommodation tripAccommodation = new TripAccommodation
        {
            UserTripID = userTripId,
            AccommodationID = accommodationId,
            CheckInDate = checkInDate,
            CheckOutDate = checkOutDate
        };

        // Add the TripAccommodation to the database context
        _dbContext.TripAccommodations.Add(tripAccommodation);

        // Save changes to the database
        _dbContext.SaveChanges();
    }
        public TripAccommodationService(TripAccommodationRepository accommodationRepository)
        {
            _accommodationRepository = accommodationRepository;
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
        public Accommodation GetAccommodationById(string accommodationId)
        {
            // Parse the accommodation ID string to an integer
            if (int.TryParse(accommodationId, out int id))
            {
                // Retrieve the accommodation with the specified ID
                return _accommRepository.GetById(id);
            }
            else
            {
                // If parsing fails or the ID is invalid, return null or handle the error accordingly
                return null;
            }
        }
        
    }
}
