using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Firstproject.Startup))]
namespace Firstproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
