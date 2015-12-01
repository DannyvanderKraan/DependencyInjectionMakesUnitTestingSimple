using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionMakesUnitTestingSimple
{
    public class SomeService
    {
        public bool DoStuff()
        {
           //Write stuff to DB
            var someRepository = new SomeRepository();
            var succes = someRepository.WriteStuffToDb();
            //Then we call some webservice to pass along some data.
            var someClient = new SomeClient();
            someClient.SomeCallToWebService();
            //Finally we'd like to write something to the log file.
            var someLogger = new SomeLogger();
            someLogger.LogStuff();

            return succes;
        }
    }
}
