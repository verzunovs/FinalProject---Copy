using BusTransportation.Data.Contracts;
using BusTransportation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Repositories
{
    public class DestinationRepository : IDestinationRepository
    {
        public void Create(Destination model)
        {
            using (var ctx = new BusTransportationContext())
            {
                ctx.Destinations.Add(model);
                ctx.SaveChanges();
            }
        }
    }
}
