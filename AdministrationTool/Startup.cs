using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdministrationTool.Startup))]
namespace AdministrationTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
