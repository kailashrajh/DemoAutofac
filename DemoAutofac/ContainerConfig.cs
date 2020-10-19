using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAutofac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();

            return builder.Build();
        }
    }
}
