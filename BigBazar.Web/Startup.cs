using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigBazar.Web.Startup))]
namespace BigBazar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
