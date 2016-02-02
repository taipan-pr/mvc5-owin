using System.Web.Mvc;
using System.Web.Routing;

namespace mvc5_owin
{
    public partial class Startup
    {
        private void RegisterRoutes()
        {
            var routes = RouteTable.Routes;

            routes.MapRoute(
               name: "Home",
               url: "{controller}/{action}",
               defaults: new { controller = "Home", action = "Index" }
           );
        }
    }
}