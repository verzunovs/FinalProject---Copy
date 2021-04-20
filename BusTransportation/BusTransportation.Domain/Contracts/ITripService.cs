using BusTransportation.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Domain.Contracts
{
    public interface ITripService
    {
        void Create(TripModel model);
        IReadOnlyCollection<TripModel> GetAll();
        TripModel GetById(int tripId);
        bool IsFreeSeats(int tripId);
        IReadOnlyCollection<TripModel> GetAllTripsByDriverId(string userId);
        void PutDriverOnTrip(int tripId, int driverId);
        void PutPassangerOnTrip(int tripId,int passengerId);
        IReadOnlyCollection<TripModel> GetAllPassangers(int tripId);
    }
}
