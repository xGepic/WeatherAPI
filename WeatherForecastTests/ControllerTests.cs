namespace WeatherForecastTests;

public class ControllerTests
{
    [Test]
    public void GetAllTest()
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
