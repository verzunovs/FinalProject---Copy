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
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IMapper _mapper;
        public DestinationController(IDestinationService destinationService, IMapper mapper)
        {
            _destinationService = destinationService;
            _mapper = mapper;
        }

        [Authorize(Roles ="Admin")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(DestinationPostModel model)
        {
            var destinationModel = _mapper.Map<DestinationModel>(model);
            _destinationService.Create(destinationModel);
            return new EmptyResult();
        }
    }
}