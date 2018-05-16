using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AeroAurora.Startup))]
namespace AeroAurora
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
