using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MacBookStore.Startup))]
namespace MacBookStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
