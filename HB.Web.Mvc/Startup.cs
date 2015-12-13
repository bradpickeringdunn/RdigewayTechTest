using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HB.Web.Mvc.Startup))]
namespace HB.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
