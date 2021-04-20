using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Domain.Models
{
    public class TripModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int DriverId { get; set; }
        public int RouteId { get; set; }
        public int BusId { get; set; }
    }
}
