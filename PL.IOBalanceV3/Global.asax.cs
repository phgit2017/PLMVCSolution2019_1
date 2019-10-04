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
using PL.IOBalanceV3.Infrastructure;

namespace PL.IOBalanceV3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyInjection resolver = new DependencyInjection();
            ContainerBuilder builder = new ContainerBuilder();
            IContainer myContainer = null;
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly());

            builder = resolver.OnConfigure(builder);

            if (myContainer == null)
            {
                myContainer = builder.Build();
            }
            else
            {
                builder.Update(myContainer);
            }

            DependencyResolver.SetResolver(new AutofacDependencyResolver(myContainer));
        }
    }
}
