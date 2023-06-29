using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ffnnn.Startup))]
namespace ffnnn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
