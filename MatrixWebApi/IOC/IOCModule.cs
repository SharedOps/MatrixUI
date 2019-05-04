using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using MatrixWebApi.Contracts;
using MatrixWebApi.Services;

namespace MatrixWebApi.IOC
{
    public class IOCModule
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<EmailService>()
                .As<IEmail>()
                .InstancePerRequest();


            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}