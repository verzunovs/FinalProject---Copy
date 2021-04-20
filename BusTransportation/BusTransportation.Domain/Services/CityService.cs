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
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;
        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public void Create(CityModel model)
        {
            var city = _mapper.Map<City>(model);
            _cityRepository.Create(city);
        }

        public IReadOnlyCollection<CityModel> GetAll()
        {
            var cities = _cityRepository.GetAll();
            var result = _mapper.Map<IReadOnlyCollection<CityModel>>(cities).ToList();
            return result;
        }
    }
}
