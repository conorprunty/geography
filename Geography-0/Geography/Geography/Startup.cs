using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Geography.Startup))]
namespace Geography
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
