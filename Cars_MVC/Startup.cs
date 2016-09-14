using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cars_MVC.Startup))]
namespace Cars_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
