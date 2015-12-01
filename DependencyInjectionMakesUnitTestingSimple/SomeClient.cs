using System.Threading;

namespace DependencyInjectionMakesUnitTestingSimple
{
    public class SomeClient : ISomeClient
    {
        public void SomeCallToWebService()
        {
            //Calling some webservice somewhere on the internet is a long running process.
            Thread.Sleep(2000);
        }
    }
}