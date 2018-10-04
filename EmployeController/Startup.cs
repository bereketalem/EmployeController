using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeController.Startup))]
namespace EmployeController
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
