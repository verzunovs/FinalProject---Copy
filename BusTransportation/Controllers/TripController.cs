using AutoMapper;
using BusTransportation.Domain.Contracts;
using BusTransportation.Domain.Models;
using BusTransportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace BusTransportation.Controllers
{
    public class TripController : Controller
    {
        private readonly ITripService _tripService;
        private readonly IMapper _mapper;

        public TripController(ITripService tripService, IMapper mapper)
        {
            _tripService = tripService;
            _mapper = mapper;
        }

        [Authorize(Roles = "Admin")]
        // GET: Trip
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(TripPostModel model)
        {
            var tripModel = _mapper.Map<TripModel>(model);
            _tripService.Create(tripModel);
            return RedirectToAction("Create", "Trip");
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var tripModels = _tripService.GetAll();
            var tripVMs = _mapper.Map<IReadOnlyCollection<TripViewModel>>(tripModels);
            return View();
        }
        [HttpGet]
        public ActionResult GetById(int tripId)
        {
            var tripModel = _tripService.GetById(tripId);
            var tripVM = _mapper.Map<TripViewModel>(tripModel);
            return View(tripVM);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public ActionResult PutPassengerOnTrip(int tripId, int passangerId)
        {
            _tripService.PutPassangerOnTrip(tripId,passangerId);
            return View();
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public ActionResult PutDriverOnTrip(int tripId, int driverId)
        {
            _tripService.PutDriverOnTrip(tripId, driverId);
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Driver")]
        public ActionResult GetAllTripsByDriverId()
        {
            var identity = User.Identity as ClaimsIdentity;
            var userId = identity.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;

            var tripModels = _tripService.GetAllTripsByDriverId(userId);
            var tripVMs = _mapper.Map<IReadOnlyCollection<TripViewModel>>(tripModels);
            return View(tripVMs);
        }
    }
}