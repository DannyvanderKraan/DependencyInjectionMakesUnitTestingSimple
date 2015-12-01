using System.Threading;

namespace DependencyInjectionMakesUnitTestingSimple
{
    public class SomeLogger : ISomeLogger
    {
        public void LogStuff()
        {
            //Disk IO's can take time.
            Thread.Sleep(1000);
        }
    }
}