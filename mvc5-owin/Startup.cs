using mvc5_owin;
using Microsoft.Owin;
using Owin;
using mvc5_owin.Middlewares;

[assembly: OwinStartup(typeof(Startup))]
namespace mvc5_owin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<Timestamp>();

            this.RegisterRoutes();

            this.RegisterBundles();
        }
    }
}