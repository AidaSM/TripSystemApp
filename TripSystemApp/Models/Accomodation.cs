using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TripSystemApp.Models
{
    public class Accommodation
    {
        [Key]
        public int AccommodationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public int DestinationID { get; set; }

        public Destination Destination { get; set; }
    }
}
