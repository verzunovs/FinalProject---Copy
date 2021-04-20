﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data.Models
{
    public class Driver
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Trip> Trips { get; set; }
    }
}
