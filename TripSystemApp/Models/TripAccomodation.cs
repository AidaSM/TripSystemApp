using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripSystemApp.Models
{
    public class TripAccommodation
    {
        [Key]
        public int TripAccommodationID { get; set; }
        public int UserTripID { get; set; }
        public int AccommodationID { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        // Navigation properties
        public UserTrip UserTrip { get; set; }
        public Accommodation Accommodation { get; set; }
    }
}
