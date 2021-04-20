using AutoMapper;
using BusTransportation.Domain.Contracts;
using System.Web.Http;

namespace BusTransportation.Controllers.Api
{
    public class RouteController : ApiController
    {
        private readonly IRouteService _routeService;
        private readonly IMapper _mapper;
        public RouteController(IRouteService routeService, IMapper mapper)
        {
            _routeService = routeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok();
        }
    }
}
