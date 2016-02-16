using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BearerAndCookie.Startup))]
namespace BearerAndCookie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ConfigureOAuth(app);
        }
    }
}
