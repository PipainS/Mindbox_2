using Mindbox.ShapeAreaCalculator.Domain.Models;
using Mindbox.ShapeAreaCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.ShapeAreaCalculator.Domain.enums;

namespace Mindbox.ShapeAreaCalculator.Application.Services.Impl
{
    public class ShapeAreaCalculatorService : IShapeAreaCalculatorService
    {
        private readonly ICircleAreaCalculator _circleAreaCalculator;
        private readonly ITriangleAreaCalculator _triangleAreaCalculator;

        public ShapeAreaCalculatorService(ICircleAreaCalculator circleAreaCalculator, ITriangleAreaCalculator triangleAreaCalculator)
        {
            _circleAreaCalculator = circleAreaCalculator;
            _triangleAreaCalculator = triangleAreaCalculator;
        }

        public double CalculateArea(Shape shape)
        {
            switch (shape.ShapeType)
            {
                case ShapeType.Circle:
                    return _circleAreaCalculator.CalculateArea((Circle)shape);
                case ShapeType.Triangle:
                    return _triangleAreaCalculator.CalculateArea((Triangle)shape);
                default:
                    throw new ArgumentException("Unknown shape type");
            }
        }
    }
}
