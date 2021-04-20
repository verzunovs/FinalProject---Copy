namespace BusTransportation.Data.Migrations
{
    using BusTransportation.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BusTransportation.Data.BusTransportationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BusTransportation.Data.BusTransportationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.



            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var existedRoles = roleManager.Roles.AsNoTracking().ToList();

            var roles = new List<IdentityRole>
            {
                new IdentityRole("Admin"),
                new IdentityRole("Driver"),
                new IdentityRole("Passenger"),
            };

            if (!existedRoles.All(x => roles.Any(y => y.Name == x.Name)))
            {
                context.Roles.AddOrUpdate(roles.ToArray());
                context.SaveChanges();
            }

            var admin = new ApplicationUser { Email = "test@test.com", UserName = "test@test.com" };
            string password = "Aa1234567*";
            var result = userManager.Create(admin, password);

            if (result.Succeeded)
            {
                userManager.AddToRole(admin.Id, roles[1].Name);
            }
            base.Seed(context);
        }
    }
}
