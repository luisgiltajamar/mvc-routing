﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Default2",
                url: "{controller}_{action}/{marca}_{modelo}_{tamano}",
                defaults: new { controller = "Nuevo", action = "Index",
                    marca=UrlParameter.Optional,
                    modelo = UrlParameter.Optional,
                    tamano=UrlParameter.Optional
                
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
