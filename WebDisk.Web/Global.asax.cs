﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebDisk.Web.App_Start;

namespace WebDisk.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            IoCConfiguration.ConfigureIocUnityContainer();
            MapperConfig.RegisterMaps();
        }
    }
}
