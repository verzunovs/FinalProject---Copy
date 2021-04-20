using BusTransportation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Contracts
{
    public interface ITripRepository
    {
        void Create(Trip model);
        IReadOnlyCollection<Trip> GetAll();
        Trip GetById(int id);
        void PutDriverOnTrip(int tripId, int driverId);
        void PutPassangerOnTrip(int tripId, int passengerId);
    }
}
