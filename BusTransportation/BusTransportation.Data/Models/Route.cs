using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Models
{
    public class Route
    {
        public int Id { get; set; }

        public int StartDestinationId { get; set; }
        public Destination StartDestination { get; set; }

        public int EndDestinationId {get;set;}
        public Destination EndDestination { get; set; }
    }
}
