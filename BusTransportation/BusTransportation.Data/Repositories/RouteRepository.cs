using BusTransportation.Data.Contracts;
using BusTransportation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        public void Create(Route model)
        {
            using(var ctx = new BusTransportationContext())
            {
                ctx.Routes.Add(model);
                ctx.SaveChanges();
            }
        }
    }
}
