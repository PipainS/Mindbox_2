using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Mindbox.ShapeAreaCalculator.Application.Services
{
    public interface IShapeFactory
    {
        Circle CreateCircle(double radius);
        Triangle CreateTriangle(double sideA, double sideB, double sideC);
    }
}
