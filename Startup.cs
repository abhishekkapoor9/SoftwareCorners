using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftwareCorners.Startup))]
namespace SoftwareCorners
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
