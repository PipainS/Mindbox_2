using Mindbox.ShapeAreaCalculator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeAreaCalculator.Application.Services.Impl
{
    public class ShapeFactory : IShapeFactory
    {
        private readonly ICircleValidationService _circleValidationService;
        private readonly ITriangleValidationService _triangleValidationService;

        public ShapeFactory(ICircleValidationService circleValidationService, ITriangleValidationService triangleValidationService)
        {
            _circleValidationService = circleValidationService;
            _triangleValidationService = triangleValidationService;
        }

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
