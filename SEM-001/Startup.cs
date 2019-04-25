using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEM_001.Startup))]
namespace SEM_001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
