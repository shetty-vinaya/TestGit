using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VinTest.Startup))]
namespace VinTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
