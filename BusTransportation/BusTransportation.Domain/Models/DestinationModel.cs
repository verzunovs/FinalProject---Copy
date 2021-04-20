using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Domain.Models
{
    public class DestinationModel
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int CityId { get; set; }
    }
}
