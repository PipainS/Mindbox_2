using Mindbox.ShapeAreaCalculator.Domain.enums;

namespace Mindbox.ShapeAreaCalculator.Domain.Models
{
    public class Circle(double radius) : Shape
    {
        public double Radius { get; } = radius;

        public override ShapeType ShapeType => ShapeType.Circle;
    }
}
