using AutoMapper;
using BusTransportation.Domain.Contracts;
using BusTransportation.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace BusTransportation.Controllers.Api
{
    public class CityController : ApiController
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;
        public CityController() { }
        public CityController(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }
        [Route("api/city/getall")]
        [HttpGet]
        public IReadOnlyCollection<CityViewModel> GetAll()
        {
            var citiesModels = _cityService.GetAll();
            var cityVM = _mapper.Map<IReadOnlyCollection<CityViewModel>>(citiesModels);
            return cityVM;
        }
    }
}
