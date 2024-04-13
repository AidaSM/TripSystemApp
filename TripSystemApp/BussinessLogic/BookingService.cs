using System;
using System.Collections.Generic;
using TripSystemApp.DataAccess;
using TripSystemApp.Models;

namespace TripSystemApp.BusinessLogic
{
    public class BookingService
    {
        private readonly TripAccommodationRepository _accommodationRepository;
        private readonly TripTransportationRepository _transportationRepository;

        public BookingService(TripAccommodationRepository accommodationRepository, TripTransportationRepository transportationRepository)
        {
            _accommodationRepository = accommodationRepository;
            _transportationRepository = transportationRepository;
        }

        // Book Accommodation for a Trip
        public void BookAccommodation(TripAccommodation tripAccommodation)
        {
            _accommodationRepository.Add(tripAccommodation);
        }

        // Book Transportation for a Trip
        public void BookTransportation(TripTransportation tripTransportation)
        {
            _transportationRepository.Add(tripTransportation);
        }

        // Cancel Accommodation Booking
        public void CancelAccommodationBooking(int tripAccommodationId)
        {
            _accommodationRepository.Delete(tripAccommodationId);
        }

        // Cancel Transportation Booking
        public void CancelTransportationBooking(int tripTransportationId)
        {
            _transportationRepository.Delete(tripTransportationId);
        }
    }
}
