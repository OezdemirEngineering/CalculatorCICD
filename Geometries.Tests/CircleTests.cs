namespace Geometries.Tests;

public class CircleTests
{
    [Fact]
    public void GetArea_radius_expectedArea()
    {
        // Arrange
        var radius = 5.0;
        var circle = new Circle(radius);
        var expectedArea = Math.PI * Math.Pow(radius, 2);

        // Act
        var area = circle.GetArea();

        // Assert
        Assert.Equal(expectedArea, area, 3);

    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2.5)]
    [InlineData(10)]
    public void GetArea_radius_expectedArea_Multiple(double radius)
    {
        // Arrange
        var circle = new Circle(radius);
        var expectedArea = Math.PI * Math.Pow(radius, 2);

        // Act
        var area = circle.GetArea();

        // Assert
        Assert.Equal(expectedArea, area, 3);
    }
}