using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trackerz.Startup))]
namespace Trackerz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
