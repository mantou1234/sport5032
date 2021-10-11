using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sport5032.Startup))]
namespace sport5032
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
