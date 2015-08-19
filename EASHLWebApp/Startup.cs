using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EASHLWebApp.Startup))]
namespace EASHLWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
