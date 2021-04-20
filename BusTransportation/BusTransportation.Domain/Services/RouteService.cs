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
    public class RouteService : IRouteService
    {
        private readonly IRouteRepository _routeRepository;
        private readonly IMapper _mapper;
        public RouteService(IRouteRepository routeRepository, IMapper mapper)
        {
            _routeRepository = routeRepository;
            _mapper = mapper;
        }

        public void Create(RouteModel model)
        {
            var route = _mapper.Map<Route>(model);
            _routeRepository.Create(route);
        }
    }
}
