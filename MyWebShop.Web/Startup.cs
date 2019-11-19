using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebShop.Web.Startup))]
namespace MyWebShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
