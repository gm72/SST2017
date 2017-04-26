using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SST2017.Startup))]
namespace SST2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
