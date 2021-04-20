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
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;
        public CityController(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var cityModels = _cityService.GetAll();
            var cityVm = _mapper.Map<IReadOnlyCollection<CityViewModel>>(cityModels);
            var getCityVm = new GetCityViewModel
            {
                Cities = cityVm,
            };
            return View(cityVm);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(CityPostModel model)
        {
            var cityModel = _mapper.Map<CityModel>(model);
            _cityService.Create(cityModel);
            return new EmptyResult();
        }
    }
}