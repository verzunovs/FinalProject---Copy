using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTransportation.Domain.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartDestinationId { get; set; }
        public int EndDestinationId { get; set; }
    }
}