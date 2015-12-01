using FakeItEasy;
using Xunit;

namespace DependencyInjectionMakesUnitTestingSimple.Tests.UnitTests
{
    public class ImprovedSomeService
    {       
        [Fact]
        public void DoStuff_GivenStuff_ExpectedStuff()
        {
            //Arrange
            ISomeRepository repository = A.Fake<ISomeRepository>();
            ISomeClient client = A.Fake<ISomeClient>();
            ISomeLogger logger = A.Fake<ISomeLogger>();
            IImprovedSomeService service = new DependencyInjectionMakesUnitTestingSimple.ImprovedSomeService(repository, 
                client, 
                logger);
            //Act
            var result = service.DoStuff();
            //Assert
            A.CallTo(() => repository.WriteStuffToDb()).MustHaveHappened();
            A.CallTo(() => client.SomeCallToWebService()).MustHaveHappened();
            A.CallTo(() => logger.LogStuff()).MustHaveHappened();
            Assert.True(result);
        }
    }
}
