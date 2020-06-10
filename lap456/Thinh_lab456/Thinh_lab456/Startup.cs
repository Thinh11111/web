using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thinh_lab456.Startup))]
namespace Thinh_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
