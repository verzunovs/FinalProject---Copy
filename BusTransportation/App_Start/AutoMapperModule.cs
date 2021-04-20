using Autofac;
using AutoMapper;
using BusTransportation.Data.Models;
using BusTransportation.Domain.Models;
using BusTransportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTransportation.App_Start
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TripPostModel, TripModel>();
                cfg.CreateMap<TripModel, Trip>();
                cfg.CreateMap<CityModel, CityViewModel>(MemberList.Destination);
                cfg.CreateMap<City, CityModel>(MemberList.Destination);
            }));

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
                .As<IMapper>()
                .InstancePerLifetimeScope();
        }
    }
}