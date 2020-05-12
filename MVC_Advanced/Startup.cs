using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Advanced.Startup))]
namespace MVC_Advanced
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
