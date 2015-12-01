using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DependencyInjectionMakesUnitTestingSimple
{
    class Program
    {

        static void Main(string[] args)
        {
            //Composition Root
            ContainerFactory.Kernel.Bind<ISomeClient>().To<SomeClient>();
            ContainerFactory.Kernel.Bind<ISomeLogger>().To<SomeLogger>();
            ContainerFactory.Kernel.Bind<ISomeRepository>().To<SomeRepository>();
            ContainerFactory.Kernel.Bind<IImprovedSomeService>().To<ImprovedSomeService>();


            //Get service from DI container.
            IImprovedSomeService service = ContainerFactory.Kernel.Get<IImprovedSomeService>();

            //Operation on service.
            var stuff = service.GetStuff();
            //Print agendas to screen.
            foreach (var foo in stuff)
            {
                Console.WriteLine($"ID: {foo.Id} Name: {foo.Name}");
            }
            Console.ReadKey();
        }
    }
}
