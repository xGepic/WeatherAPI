using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using WeatherAPI.Controllers;

namespace WeatherForecastTests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //Arrange
            var loggerStub = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerStub.Object);

            //Act
            var result = controller.Get();

            //Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}