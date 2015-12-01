using System.Collections;

namespace DependencyInjectionMakesUnitTestingSimple
{
    public interface IImprovedSomeService
    {
        bool DoStuff();
        System.Collections.Generic.IEnumerable<Foo> GetStuff();
    }
}