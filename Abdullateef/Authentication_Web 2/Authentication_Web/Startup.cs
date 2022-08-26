using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authentication_Web.Startup))]
namespace Authentication_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
