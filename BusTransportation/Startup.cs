using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusTransportation.Startup))]
namespace BusTransportation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
