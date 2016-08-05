using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restaurant_project.Startup))]
namespace Restaurant_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
