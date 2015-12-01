using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionMakesUnitTestingSimple
{
    public class ImprovedSomeService : IImprovedSomeService
    {
        private ISomeLogger SomeLogger { get; set; }
        private ISomeClient SomeClient { get; set; }
        private ISomeRepository SomeRepository { get; set; }
        public ImprovedSomeService(ISomeRepository someRepository,
            ISomeClient someClient,
            ISomeLogger someLogger)
        {
            if (someRepository == null)
            {
                throw new ArgumentNullException(nameof(someRepository));
            }
            if (someClient == null)
            {
                throw new ArgumentNullException(nameof(someClient));
            }
            if (someLogger == null)
            {
                throw new ArgumentNullException(nameof(someLogger));
            }

            this.SomeRepository = someRepository;
            this.SomeClient = someClient;
            this.SomeLogger = someLogger;

        }
        public bool DoStuff()
        {
            //Write stuff to DB
            var succes = SomeRepository.WriteStuffToDb();
            //Then we call some webservice to pass along some data.
            SomeClient.SomeCallToWebService();
            //Finally we'd like to write something to the log file.
            SomeLogger.LogStuff();
            return succes;
        }

        public IEnumerable<Foo> GetStuff()
        {
            return new List<Foo>()
            {
                new Foo() {Id = 1, Name = "1"},
                new Foo() {Id = 2, Name = "2"}
            };
        }
    }
}
