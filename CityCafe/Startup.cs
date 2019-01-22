using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CityCafe.Startup))]
namespace CityCafe
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
