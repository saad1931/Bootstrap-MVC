using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B_MVC.Startup))]
namespace B_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
