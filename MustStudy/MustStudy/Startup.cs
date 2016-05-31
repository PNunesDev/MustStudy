using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MustStudy.Startup))]
namespace MustStudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
