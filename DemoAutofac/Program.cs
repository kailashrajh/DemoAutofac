using System;
using Autofac;
using DemoLibrary;

namespace DemoAutofac
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var dateWriter = scope.Resolve<IDateWriter>();

                dateWriter.WriteDate();
                Console.ReadKey();
            }
        }
    }
}
