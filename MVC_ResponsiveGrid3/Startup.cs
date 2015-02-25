using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_ResponsiveGrid3.Startup))]
namespace MVC_ResponsiveGrid3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
