using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicMVCAppWithEntityFramework.Startup))]
namespace BasicMVCAppWithEntityFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
