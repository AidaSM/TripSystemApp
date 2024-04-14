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
        // Create a new TripTransportation object
        TripTransportation tripTransportation = new TripTransportation
        {
            UserTripID = userTripId,
            TransportationID = transportationId,
            DepartureDate = departureDate,
            ArrivalDate = arrivalDate
        };

        // Add the TripTransportation to the database context
        _dbContext.TripTransportations.Add(tripTransportation);

        // Save changes to the database
        _dbContext.SaveChanges();
    }
        public TripTransportationService(TripTransportationRepository transportationRepository)
        {
            _transportationRepository = transportationRepository;
        }
        
        public List<TripTransportation> GetTransportationsByUserTripID(int userTripID)
        {
            // Retrieve transportations associated with the specified user trip ID
            return _transportationRepository.GetTransportationsByUserTripID(userTripID);
        }
        public List<TransportationOption> GetTransportationsByDestinationAndTime(string destination, DateTime departureDate, string transportType)
        {
            // Retrieve transportations associated with the specified destination and departure date
            // Assuming the destination name is stored in the Destination property of TripTransportation
            return _transportationOptionsRepository.GetAll()
                .Where(t => t.ArrivalLocation == destination && t.DepartureTime.Date >= departureDate.Date && t.Type == transportType)
                .ToList();
        }
        public TransportationOption GetTransportationById(string transportationId)
        {
            // Parse the transportation ID string to an integer
            if (int.TryParse(transportationId, out int id))
            {
                // Retrieve the transportation option with the specified ID
                return _transportationOptionsRepository.GetById(id);
            }
            else
            {
                // If parsing fails or the ID is invalid, return null or handle the error accordingly
                return null;
            }
        }
    }
}
