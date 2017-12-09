using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ged.Startup))]
namespace ged
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
