using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lossAnalytics.Startup))]
namespace lossAnalytics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
