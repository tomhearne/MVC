using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mainmeetsmarket.Startup))]
namespace mainmeetsmarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
