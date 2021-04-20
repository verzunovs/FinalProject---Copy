using BusTransportation.Data.Contracts;
using BusTransportation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BusTransportation.Data.Repositories
{
    public class TripRepository : ITripRepository
    {
        public void Create(Trip model)
        {
           using(var ctx = new BusTransportationContext())
            {
                ctx.Trips.Add(model);
                ctx.SaveChanges();
            }
        }

        public IReadOnlyCollection<Trip> GetAll()
        {
            using(var ctx = new BusTransportationContext())
            {
                var trips = ctx.Trips.Include(x => x.Passengers).Include(x=>x.Driver);
                return trips.ToList();
            }
        }

        public Trip GetById(int id)
        {
            using(var ctx = new BusTransportationContext())
            {
                var trip = ctx.Trips.Include(x=>x.Passengers).Include(x=>x.Bus).First(x => x.Id == id);
                return trip;
            }
        }

        public void PutDriverOnTrip(int tripId, int driverId)
        {
            using(var ctx = new BusTransportationContext())
            {
                var trip = ctx.Trips.First(x => x.Id == tripId);
                trip.DriverId = driverId;
                ctx.SaveChanges();
            }
        }

        public void PutPassangerOnTrip(int tripId, int passengerId)
        {
            using (var ctx = new BusTransportationContext())
            {
                var trip = ctx.Trips.First(x => x.Id == tripId);
                trip.Passengers.Add(ctx.Passengers.First(x => x.Id == passengerId));
                ctx.SaveChanges();
            }
        }
    }
}
