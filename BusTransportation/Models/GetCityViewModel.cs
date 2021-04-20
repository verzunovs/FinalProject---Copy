using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTransportation.Models
{
    public class GetCityViewModel
    {
        public IReadOnlyCollection<CityViewModel> Cities { get; set; }
    }
}