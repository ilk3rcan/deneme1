using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Deneme
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //dddd
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
