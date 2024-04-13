using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripSystemApp.Models
{
    public class UserTrip
    {
        [Key]
        public int UserTripID { get; set; }
        public int UserID { get; set; }
        public int DestinationID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Destination Destination { get; set; }
    }
}
