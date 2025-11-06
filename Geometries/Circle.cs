using Geometries.Contracts;

namespace Geometries;

public class Circle: IGeometry
{
    private readonly double radius;


    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle()
    {
        this.radius = 1.0;
    }

    public double GetArea()
    {
        var area = Math.PI * Math.Pow(radius, 2);
        return area;
    }

    public double GetPathLength()
    {
        var pathLength = 2 * Math.PI * radius;
        return pathLength;
    }
}
