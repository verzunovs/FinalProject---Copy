using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Route> FinalDestinationOfRoutes { get; set; }
        public ICollection<Route> StartDestinationOfRoutes { get; set; }

    }
}
