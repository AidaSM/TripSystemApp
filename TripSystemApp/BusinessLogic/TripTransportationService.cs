using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripSystemApp.DataAccess;
using TripSystemApp.Models;

namespace TripSystemApp.BussinessLogic
{
    internal class TripTransportationService
    {
        private readonly TripTransportationRepository _transportationRepository;
        private readonly TransportationOptionRepository _transportationOptionsRepository;
        private readonly TravelDbContext _dbContext;

    public TripTransportationService(TravelDbContext dbContext, TransportationOptionRepository transportationOptionsRepository)
    {
        _dbContext = dbContext;
        _transportationOptionsRepository = transportationOptionsRepository ?? throw new ArgumentNullException(nameof(transportationOptionsRepository));

        }

        public void CreateTripTransportation(int userTripId, int transportationId, DateTime departureDate, DateTime arrivalDate)
    {
        TripTransportation tripTransportation = new TripTransportation
        {
            UserTripID = userTripId,
            TransportationID = transportationId,
            DepartureDate = departureDate,
            ArrivalDate = arrivalDate
        };

        _dbContext.TripTransportations.Add(tripTransportation);

        _dbContext.SaveChanges();
    }
        public TripTransportationService(TripTransportationRepository transportationRepository)
        {
            _transportationRepository = transportationRepository;
        }
        
        public List<TripTransportation> GetTransportationsByUserTripID(int userTripID)
        {
            return _transportationRepository.GetTransportationsByUserTripID(userTripID);
        }
        public List<TransportationOption> GetTransportationsByDestinationAndTime(string destination, DateTime departureDate, string transportType)
        {
            return _transportationOptionsRepository.GetAll()
                .Where(t => t.ArrivalLocation == destination && t.DepartureTime.Date >= departureDate.Date && t.Type == transportType)
                .ToList();
        }
        public TransportationOption GetTransportationById(string transportationId)
        {
            if (int.TryParse(transportationId, out int id))
            {
                return _transportationOptionsRepository.GetById(id);
            }
            else
            {
                return null;
            }
        }
    }
}
