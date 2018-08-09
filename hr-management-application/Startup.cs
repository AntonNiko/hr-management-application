using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hr_management_application.Startup))]
namespace hr_management_application
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
