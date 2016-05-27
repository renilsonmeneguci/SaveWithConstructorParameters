using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaveContructerWhitParameters.Startup))]
namespace SaveContructerWhitParameters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
