using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTransportation.Models
{
    public class RoutePostModel
    {
        public int StartDestinationId { get; set; }
        public int EndDestinationId { get; set; }
    }
}