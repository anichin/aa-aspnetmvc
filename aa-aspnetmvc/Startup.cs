using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aa_aspnetmvc.Startup))]
namespace aa_aspnetmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
