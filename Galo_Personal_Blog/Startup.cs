using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Galo_Personal_Blog.Startup))]
namespace Galo_Personal_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
