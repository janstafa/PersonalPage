using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using PersonalPage.Models;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Tests.Helpers
{
    public static class ContainerHelperTest
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


        public static ContainerBuilder GetBuilder()
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<TwitterClient>().AsImplementedInterfaces();
            builder.RegisterType<TwitterService>();
            builder.RegisterType<ServiceRecordModel>();

            return builder;
        }

        private static IContainer GetContainer()
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<TwitterClient>();
            builder.RegisterType<TwitterService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            return container;
        }


        public static IContainer RegisterAndUpdate(IContainer container, object mockToRegister)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterInstance(mockToRegister);
         //   

            containerBuilder.Update(container);

            return container;
        }
    }
}