using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Mindbox.ShapeAreaCalculator.Application.Services
{
    public interface ITriangleAreaCalculator
    {
        double CalculateArea(Triangle triangle);
    }
}
