using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Autofac;
using System.Reflection;
using System.Web.Http;
using Autofac.Integration.WebApi;
using Autofac.Configuration;

[assembly: OwinStartup(typeof(DemoAutofac.Startup))]

namespace DemoAutofac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ConfigureAutofac(app);
        }

        private void ConfigureAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Register individual components
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            var container = builder.Build();

            var config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
