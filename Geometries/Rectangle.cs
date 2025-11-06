using Geometries.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometries;

public class Rectangle(double with, double heigth) : IGeometry
{
    public double GetArea()
    {
        var area = with * heigth;
        return area;
    }

    public double GetPathLength()
    {
        var pathLength = 2 * (with + heigth);
        return pathLength;
    }
}
