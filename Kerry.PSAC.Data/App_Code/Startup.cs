using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kerry.PSAC.Data.Startup))]
namespace Kerry.PSAC.Data
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
