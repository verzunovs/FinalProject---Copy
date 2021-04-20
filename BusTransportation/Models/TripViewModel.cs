using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTransportation.Models
{
    public class TripViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int DriverId { get; set; }
        public int RouteId { get; set; }
        public int BusId { get; set; }
    }
}