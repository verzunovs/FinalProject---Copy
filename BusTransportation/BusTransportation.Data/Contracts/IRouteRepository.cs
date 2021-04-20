﻿using BusTransportation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Contracts
{
    public interface IRouteRepository
    {
        void Create(Route model);
    }
}
