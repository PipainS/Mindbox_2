using Mindbox.ShapeAreaCalculator.Domain.Models;
using Mindbox.ShapeAreaCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeAreaCalculator.Application.Services.Impl
{
    public class ShapeAreaCalculatorService
    {
        private readonly ITriangleAreaCalculator _triangleAreaCalculator;
        private readonly ICircleAreaCalculator _circleAreaCalculator;

        public ShapeAreaCalculatorService(ITriangleAreaCalculator triangleAreaCalculator, ICircleAreaCalculator circleAreaCalculator)
        {
            _triangleAreaCalculator = triangleAreaCalculator;
            _circleAreaCalculator = circleAreaCalculator;
        }

        public double CalculateArea(Shape shape)
        {
            return shape switch
            {
                Circle circle => _circleAreaCalculator.CalculateArea(circle),
                Triangle triangle => _triangleAreaCalculator.CalculateArea(triangle),
                _ => throw new ArgumentException("Invalid shape type")
            };
        }
    }
}
