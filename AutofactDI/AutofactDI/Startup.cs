using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutofactDI.Startup))]
namespace AutofactDI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
