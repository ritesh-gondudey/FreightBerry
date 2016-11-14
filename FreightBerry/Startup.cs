using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreightBerry.Startup))]
namespace FreightBerry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
