using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee_Payroll_Web.Startup))]
namespace Employee_Payroll_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
