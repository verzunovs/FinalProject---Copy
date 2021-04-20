using Autofac;
using Autofac.Integration.Mvc;
using BusTransportation.Data.Repositories;
using BusTransportation.Domain.Services;
using BusTransportation.Domain.Contracts;
using System.Web.Mvc;
using BusTransportation.Data.Contracts;
using System.Reflection;
using Autofac.Integration.WebApi;
using System.Web.Http;

namespace BusTransportation.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<CityService>().As<ICityService>();
            builder.RegisterType<CityRepository>().As<ICityRepository>();

            builder.RegisterModule<AutoMapperModule>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}