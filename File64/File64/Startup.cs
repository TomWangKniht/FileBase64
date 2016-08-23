using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(File64.Startup))]
namespace File64
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
