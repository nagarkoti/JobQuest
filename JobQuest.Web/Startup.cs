using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobQuest.Web.Startup))]
namespace JobQuest.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
