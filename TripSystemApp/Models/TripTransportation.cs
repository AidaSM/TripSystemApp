using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripSystemApp.Models
{
    public class TripTransportation
    {
        [Key]
        public int TripTransportationID { get; set; }
        public int UserTripID { get; set; }
        public int TransportationID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }

        // Navigation properties
        public UserTrip UserTrip { get; set; }
        public TransportationOption TransportationOption { get; set; }
    }
}
