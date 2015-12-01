using System.Threading;
using Xunit;

namespace DependencyInjectionMakesUnitTestingSimple.Tests.IntegrationTests
{
    public class SomeService
    {
        [Fact]
        public void DoStuff_GivenStuff_ExpectedStuff()
        {
            //Arrange: New-up SomeService
            var someService = new DependencyInjectionMakesUnitTestingSimple.SomeService();          
            //Act:Make it DoStuff
            var succes = someService.DoStuff();
            //Assert: If writing to the DB/call to the webservice/logging succeeded
            Assert.True(succes && VerifyCallToWebservice() && VerifyWritingToLog());
        }

        private bool VerifyWritingToLog()
        {
            //Long running process.
            Thread.Sleep(1000);
            //Verify somehow if writing to log succeeded and return wether succesful or not.
            return true;
        }

        private bool VerifyCallToWebservice()
        {
            //Long running process.
            Thread.Sleep(2000);
            //Verify somehow if call to webservice succeeded and return wether succesful or not.
            return true;
        }
    }
}
