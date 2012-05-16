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
            get
            {
                if (_container == null)
                {
                    _container = GetContainer();
                }

                return _container;
            }
        }


        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(typeof (MvcApplication).Assembly);
            builder.RegisterAssemblyTypes(typeof (MvcApplication).Assembly).AsImplementedInterfaces();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            return container;
        }
    }
}