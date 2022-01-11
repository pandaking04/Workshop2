using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Workshop2.Startup))]
namespace Workshop2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
