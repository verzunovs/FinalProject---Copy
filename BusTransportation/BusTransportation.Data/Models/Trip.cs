using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int BusId { get; set; }
        public Bus Bus { get; set; }

        public ICollection<Passenger> Passengers { get; set; }
    }
}
