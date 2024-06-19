using Mindbox.ShapeAreaCalculator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeAreaCalculator.Application.Services
{
    public interface IShapeFactory
    {
        Circle CreateCircle(double radius);
        Triangle CreateTriangle(double sideA, double sideB, double sideC);
    }
}
