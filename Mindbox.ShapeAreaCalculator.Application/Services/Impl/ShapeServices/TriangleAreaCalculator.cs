using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Mindbox.ShapeAreaCalculator.Application.Services.Impl.ShapeServices
{
    public class TriangleAreaCalculator : ITriangleAreaCalculator
    {
        public double CalculateArea(Triangle triangle)
        {
            double semiPerimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - triangle.SideA) * (semiPerimeter - triangle.SideB) * (semiPerimeter - triangle.SideC));
        }
    }
}
