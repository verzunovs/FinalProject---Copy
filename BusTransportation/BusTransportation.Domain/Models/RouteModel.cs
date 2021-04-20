using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Domain.Models
{
    public class RouteModel
    {
        public int Id { get; set; }
        public int StartDestinationId { get; set; } 
        public int EndDestinationId { get; set; }
    }
}
