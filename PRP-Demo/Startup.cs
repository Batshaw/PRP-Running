using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRP_Demo.Startup))]
namespace PRP_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
