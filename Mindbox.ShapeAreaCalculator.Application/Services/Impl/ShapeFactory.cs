using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Mindbox.ShapeAreaCalculator.Application.Services.Impl
{
    public class ShapeFactory(ICircleValidationService circleValidationService, ITriangleValidationService triangleValidationService) : IShapeFactory
    {
        private readonly ICircleValidationService _circleValidationService = circleValidationService;
        private readonly ITriangleValidationService _triangleValidationService = triangleValidationService;

        public Circle CreateCircle(double radius)
        {
            _circleValidationService.Validate(radius);
            return new Circle(radius);
        }

        public Triangle CreateTriangle(double sideA, double sideB, double sideC)
        {
            _triangleValidationService.Validate(sideA, sideB, sideC);
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
