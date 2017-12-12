using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using DI.Data;
using DI.Logic;

namespace DI.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<ClientLogic>().As<IClientLogic>();
            builder.RegisterType<NoSqlClientRepository>().As<IClientRepository>();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}