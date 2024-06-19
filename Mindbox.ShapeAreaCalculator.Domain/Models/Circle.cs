using Mindbox.ShapeAreaCalculator.Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeAreaCalculator.Domain.Models
{
    public class Circle(double radius) : Shape
    {
        public double Radius { get; } = radius;

        public override ShapeType ShapeType => ShapeType.Circle;
    }
}
