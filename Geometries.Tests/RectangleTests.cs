namespace Geometries.Tests;

public class RectangleTests
{
    [Fact]
    public void GetArea_widthHeight_expectedArea()
    {
        // Arrange
        var width = 3.0;
        var height = 4.0;
        var rectangle = new Rectangle(width, height);
        var expectedArea = width * height;

        // Act
        var area = rectangle.GetArea();

        // Assert
        Assert.Equal(expectedArea, area, 3);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 2)]
    [InlineData(2.5, 4)]
    [InlineData(10, 10)]
    public void GetArea_widthHeight_expectedArea_Multiple(double width, double height)
    {
        // Arrange
        var rectangle = new Rectangle(width, height);
        var expectedArea = width * height;

        // Act
        var area = rectangle.GetArea();

        // Assert
        Assert.Equal(expectedArea, area, 3);
    }
}
