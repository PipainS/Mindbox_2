using Mindbox.ShapeAreaCalculator.Domain.enums;

namespace Mindbox.ShapeAreaCalculator.Domain.Models
{
    public class Triangle(double sideA, double sideB, double sideC) : Shape
    {
        public override ShapeType ShapeType => ShapeType.Triangle;

        public double SideA { get; } = sideA;
        public double SideB { get; } = sideB;
        public double SideC { get; } = sideC;

        public bool IsRightAngled()
        {
            double[] sides = [SideA, SideB, SideC];
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }
    }
}
