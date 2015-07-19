﻿using System.Web.Http;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "Periodic Table",
                routeTemplate: "PeriodicTable/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
