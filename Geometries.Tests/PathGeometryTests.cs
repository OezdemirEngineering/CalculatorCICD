using Geometries.Contracts;


namespace Geometries.Tests;

public class PathGeometryTests
{
    [Fact]
    public void GetArea_MultipleGeometries_CorrectTotalArea()
    {
        // Arrange

        var mockedGeometry1 = Substitute.For<IGeometry>();
        mockedGeometry1.GetArea().Returns(10.0);


        var mockedGeometry2 = Substitute.For<IGeometry>();
        mockedGeometry2.GetArea().Returns(20.0);

        var path = new PathGeometry([mockedGeometry1, mockedGeometry2]);

        var expectedTotalArea = 30.0;

        // Act
        var area = path.GetArea();

        // Assert
        area.ShouldBe(expectedTotalArea, 3);

    }

    [Fact]
    public void GetPathLength_MultipleGeometries_CorrectTotalPathLength()
    {
        // Arrange
        var mockedGeometry1 = Substitute.For<IGeometry>();
        mockedGeometry1.GetPathLength().Returns(15.0);
        var mockedGeometry2 = Substitute.For<IGeometry>();
        mockedGeometry2.GetPathLength().Returns(25.0);
        var path = new PathGeometry([mockedGeometry1, mockedGeometry2]);
        var expectedTotalPathLength = 40.0;


        // Act
        var pathLength = path.GetPathLength();

        // Assert
        pathLength.ShouldBe(expectedTotalPathLength, 3);
    }
}
