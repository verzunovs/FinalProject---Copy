using AutoMapper;
using BusTransportation.Data.Contracts;
using BusTransportation.Data.Models;
using BusTransportation.Domain.Contracts;
using BusTransportation.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Domain.Services
{
    public class TripService : ITripService
    {
        private readonly ITripRepository _tripRepository;
        private readonly IMapper _mapper;

        public TripService(ITripRepository tripRepository, IMapper mapper)
        {
            _tripRepository = tripRepository;
            _mapper = mapper;
        }

        public void Create(TripModel model)
        {
            var trip = _mapper.Map<Trip>(model);
            _tripRepository.Create(trip);
        }

        public IReadOnlyCollection<TripModel> GetAll()
        {
            var trips = _tripRepository.GetAll();
            var tripModels = _mapper.Map<IReadOnlyCollection<TripModel>>(trips);
            return tripModels;
        }

        public IReadOnlyCollection<TripModel> GetAllPassangers(int tripId)
        {
            var trips = _tripRepository.GetAll();
            var trips2 = trips.Where(x => x.Id == tripId);
            var tripModels = _mapper.Map<IReadOnlyCollection<TripModel>>(trips);
            return tripModels;
        }

        public IReadOnlyCollection<TripModel> GetAllTripsByDriverId(string userId)
        {
            var trips = _tripRepository.GetAll();
            var tripByDriverId = trips.Where(x => x.Driver.UserId == userId);
            var tripModels = _mapper.Map<IReadOnlyCollection<TripModel>>(tripByDriverId);
            return tripModels;
        }

        public TripModel GetById(int tripId)
        {
            var trip = _tripRepository.GetById(tripId);
            var tripModel = _mapper.Map<TripModel>(trip);
            return tripModel;
        }

        public bool IsFreeSeats(int tripId)
        {
            var trip = _tripRepository.GetById(tripId);
            var seats = trip.Bus.Capacity;
            var occupiedSeats = trip.Passengers.Count();
            if (seats > occupiedSeats)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PutDriverOnTrip(int tripId, int driverId) => _tripRepository.PutDriverOnTrip(tripId, driverId);

        public void PutPassangerOnTrip(int tripId, int passengerId)
        {
            if (IsFreeSeats(tripId))
            {
                _tripRepository.PutPassangerOnTrip(tripId, passengerId);
            }
            else
            {
                throw new Exception("There are not aviable sears on this trip!");
            }
        }
    }
}
