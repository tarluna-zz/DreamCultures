using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DreamCultures.Startup))]
namespace DreamCultures
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
