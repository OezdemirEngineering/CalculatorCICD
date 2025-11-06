using Geometries.Contracts;

namespace Geometries;

public class PathGeometry(List<IGeometry> geometries) : IGeometry
{
    public double GetArea()
    {
        var area = geometries.Sum(g => g.GetArea());
        return area;
    }

    public double GetPathLength()
    {
        var pathLength = geometries.Sum(g => g.GetPathLength());
        return pathLength;
    }
}
