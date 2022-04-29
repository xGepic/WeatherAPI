using System;

namespace WeatherAPITests;

public class Tests
{
    [Test]
    public void GetWeatherForecast_WithNotNull_ReturnsTrue()
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
