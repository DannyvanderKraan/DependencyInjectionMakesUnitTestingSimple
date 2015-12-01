using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace DependencyInjectionMakesUnitTestingSimple
{
    public static class ContainerFactory
    {
        public static bool IsInitialized { get; set; } = false;

        public static IKernel Kernel { get; set; } = new StandardKernel();


    }
}
