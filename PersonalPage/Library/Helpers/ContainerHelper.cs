using System;
using System.IO;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

namespace PersonalPage.Library.Helpers
{
    public static class ContainerHelper
    {
        private static IContainer _container;

        public static IContainer Container
        {
            get { return _container ?? (_container = GetContainer()); }
        }


        private static IContainer GetContainer()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);


            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(typeof (MvcApplication).Assembly);
            builder.RegisterAssemblyTypes(typeof (MvcApplication).Assembly).AsImplementedInterfaces();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            return container;
        }
    }
}