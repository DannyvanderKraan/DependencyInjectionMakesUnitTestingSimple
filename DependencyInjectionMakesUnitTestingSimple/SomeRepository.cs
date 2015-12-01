using System.Threading;

namespace DependencyInjectionMakesUnitTestingSimple
{
    public class SomeRepository : ISomeRepository
    {
        public bool WriteStuffToDb()
        {
            //Long running process writing stuff to DB.
            Thread.Sleep(2000);
            //Writing stuff to DB succeeded ofcourse. 
            return true;
        }
    }
}