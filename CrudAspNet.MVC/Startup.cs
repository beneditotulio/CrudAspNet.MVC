using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudAspNet.MVC.Startup))]
namespace CrudAspNet.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
