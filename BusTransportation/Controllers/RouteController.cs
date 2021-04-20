using AutoMapper;
using BusTransportation.Domain.Contracts;
using BusTransportation.Domain.Models;
using BusTransportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusTransportation.Controllers
{
    public class RouteController : Controller
    {
        private readonly IRouteService _routeService; 
        private readonly IMapper _mapper;

        public RouteController(IRouteService routeService, IMapper mapper)
        {
            _routeService = routeService;
            _mapper = mapper;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(RoutePostModel model)
        {
            var routeModel = _mapper.Map<RouteModel>(model);
            _routeService.Create(routeModel);
            return new EmptyResult();
        }
    }
}