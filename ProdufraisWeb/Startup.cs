using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProdufraisWeb.Startup))]
namespace ProdufraisWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
