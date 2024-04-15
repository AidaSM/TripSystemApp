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
        TripAccommodation tripAccommodation = new TripAccommodation
        {
            UserTripID = userTripId,
            AccommodationID = accommodationId,
            CheckInDate = checkInDate,
            CheckOutDate = checkOutDate
        };

        _dbContext.TripAccommodations.Add(tripAccommodation);

        _dbContext.SaveChanges();
    }
        public TripAccommodationService(TripAccommodationRepository accommodationRepository)
        {
            _accommodationRepository = accommodationRepository;
        }
        
        public List<Accommodation> SearchAccommodations(string destination, string accommodationType)
        {
            return _accommRepository.GetAccommodationsByDestinationAndType(destination, accommodationType);
        }

        public List<TripAccommodation> GetAccommodationsByUserTripID(int userTripID)
        {
            return _accommodationRepository.GetAccommodationsByUserTripID(userTripID);
        }
        public Accommodation GetAccommodationById(string accommodationId)
        {
            if (int.TryParse(accommodationId, out int id))
            {
                return _accommRepository.GetById(id);
            }
            else
            {
                return null;
            }
        }
        
    }
}
