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

        public TripTransportationService(TripTransportationRepository transportationRepository)
        {
            _transportationRepository = transportationRepository;
        }
        public TripTransportationService(TransportationOptionRepository transportationOptionsRepository)
        {
            _transportationOptionsRepository = transportationOptionsRepository ?? throw new ArgumentNullException(nameof(transportationOptionsRepository));
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
                .Where(t => t.ArrivalLocation == destination && t.DepartureTime.Date == departureDate.Date && t.Type == transportType)
                .ToList();
        }
    }
}
