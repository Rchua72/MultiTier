using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrontEndWebRole.Startup))]
namespace FrontEndWebRole
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
