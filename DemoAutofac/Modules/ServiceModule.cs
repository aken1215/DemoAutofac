using Autofac;
using DemoAutofac.Services.Archer;
using DemoAutofac.Services.Cavalry;
using DemoAutofac.Services.Infantry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAutofac.Modules
{
public class ServiceModule: Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<Archer>().As<IArcher>();
        builder.RegisterType<Infantry>().As<IInfantry>();
        builder.RegisterType<Cavalry>().As<ICavalry>();
    }
}
}