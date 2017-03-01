using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof (handycareappService.Startup))]
namespace handycareappService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
            ConfigureAuth(app);
        }
    }
}