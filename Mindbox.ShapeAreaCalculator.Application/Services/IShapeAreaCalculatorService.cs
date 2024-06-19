using Mindbox.ShapeAreaCalculator.Domain;

namespace Mindbox.ShapeAreaCalculator.Application.Services
{
    public interface IShapeAreaCalculatorService
    {
        double CalculateArea(Shape shape);
    }
}
