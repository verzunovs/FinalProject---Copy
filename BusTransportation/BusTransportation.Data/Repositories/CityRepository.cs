using BusTransportation.Data.Contracts;
using BusTransportation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Repositories
{
    public class CityRepository : ICityRepository
    {
        public void Create(City model)
        {
            using(var ctx = new BusTransportationContext())
            {
                ctx.Cities.Add(model);
                ctx.SaveChanges();
            }
        }

        public IReadOnlyCollection<City> GetAll()
        {
            using(var ctx = new BusTransportationContext())
            {
                return ctx.Cities.ToList();
            }
        }
    }
}
