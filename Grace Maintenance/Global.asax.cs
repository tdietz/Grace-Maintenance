using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Configuration;
using Grace.Models;
using Ninject.Web.Mvc;
using Ninject.Modules;
using Ninject;
using Grace.Core;
using System.Reflection;

namespace Grace
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}/{returnId}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional, returnId = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            var kernel = new StandardKernel(new AppLoaderDependencies());
            var AppLoaderService = kernel.Get<IAppLoaderService>();
            AppLoaderService.AppStartup();
        }
    }
}