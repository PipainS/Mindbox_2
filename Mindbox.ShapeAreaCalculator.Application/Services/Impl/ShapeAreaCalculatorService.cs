using Mindbox.ShapeAreaCalculator.Domain.Models;
using Mindbox.ShapeAreaCalculator.Domain;
using Mindbox.ShapeAreaCalculator.Domain.enums;

namespace Mindbox.ShapeAreaCalculator.Application.Services.Impl
{
    public class ShapeAreaCalculatorService(ICircleAreaCalculator circleAreaCalculator, ITriangleAreaCalculator triangleAreaCalculator) : IShapeAreaCalculatorService
    {
        private readonly ICircleAreaCalculator _circleAreaCalculator = circleAreaCalculator;
        private readonly ITriangleAreaCalculator _triangleAreaCalculator = triangleAreaCalculator;

        public double CalculateArea(Shape shape)
        {
            return shape.ShapeType switch
            {
                ShapeType.Circle => _circleAreaCalculator.CalculateArea((Circle)shape),
                ShapeType.Triangle => _triangleAreaCalculator.CalculateArea((Triangle)shape),
                _ => throw new ArgumentException("Unknown shape type"),
            };
        }
    }
}
