using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mybrary.Startup))]
namespace Mybrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
