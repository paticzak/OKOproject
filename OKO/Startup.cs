using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OKO.Startup))]
namespace OKO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
