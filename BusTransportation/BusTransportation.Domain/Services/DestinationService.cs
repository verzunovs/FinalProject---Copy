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
    public class DestinationService : IDestinationService
    {
        private readonly IDestinationRepository _destinationRepository;
        private readonly IMapper _mapper;
        public DestinationService(IDestinationRepository destinationRepository, IMapper mapper)
        {
            _destinationRepository = destinationRepository;
            _mapper = mapper;
        }

        public void Create(DestinationModel model)
        {
            var destination = _mapper.Map<Destination>(model);
            _destinationRepository.Create(destination);
        }
    }
}
