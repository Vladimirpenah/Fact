using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fact.Startup))]
namespace Fact
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
