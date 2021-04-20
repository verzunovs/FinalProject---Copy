using BusTransportation.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Domain.Contracts
{
    public interface IDestinationService
    {
        void Create(DestinationModel model);
    }
}
