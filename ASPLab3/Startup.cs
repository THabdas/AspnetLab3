using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPLab3.Startup))]
namespace ASPLab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
