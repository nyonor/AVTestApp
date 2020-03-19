using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using AVTestApp.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AVTestApp.Presentation.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // IOC

            var builder = new ContainerBuilder();

            builder.RegisterModule(new BLLIoCModule());
            builder.RegisterModule(new DALIoCModule());
            builder.AddAutoMapper(typeof(MvcApplication).Assembly);

            // MVC setup

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
