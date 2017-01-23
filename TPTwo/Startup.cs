using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TPTwo.Startup))]

namespace TPTwo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}