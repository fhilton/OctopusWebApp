using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctopusWebApp.Startup))]
namespace OctopusWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
