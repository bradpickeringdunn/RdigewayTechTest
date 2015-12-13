using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HB.Web.WebForms.Startup))]
namespace HB.Web.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
