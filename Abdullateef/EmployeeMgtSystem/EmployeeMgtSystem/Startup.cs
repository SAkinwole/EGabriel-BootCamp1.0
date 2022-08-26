using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeMgtSystem.Startup))]
namespace EmployeeMgtSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
