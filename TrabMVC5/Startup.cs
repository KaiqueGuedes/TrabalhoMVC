using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrabMVC5.Startup))]
namespace TrabMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
