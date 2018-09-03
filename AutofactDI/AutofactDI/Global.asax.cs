using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using AutofactDI.Models;

namespace AutofactDI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            ContainerBuilder build = new ContainerBuilder();
            build.RegisterType<PersonRepository>().As<IPerson>();

            build.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(a => a.Name.EndsWith("Controller"));
            IContainer container = build.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
