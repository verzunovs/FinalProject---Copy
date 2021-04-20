using BusTransportation.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransportation.Data
{
    public class BusTransportationContext : IdentityDbContext<ApplicationUser>
    {
        public BusTransportationContext() : base("BusTransDB") { }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Route> Routes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destination>()
                .HasMany(x => x.FinalDestinationOfRoutes)
                .WithRequired(x => x.EndDestination)
                .HasForeignKey(x => x.EndDestinationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Destination>()
                .HasMany(x => x.StartDestinationOfRoutes)
                .WithRequired(x => x.StartDestination)
                .HasForeignKey(x => x.StartDestinationId)
                .WillCascadeOnDelete(false);

        }
    }
}
