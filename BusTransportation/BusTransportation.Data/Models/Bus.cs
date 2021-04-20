using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public ICollection<Trip> Trips { get; set; }
    }
}
