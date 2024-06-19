using Mindbox.ShapeAreaCalculator.Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeAreaCalculator.Domain
{
    public abstract class Shape
    {
        public abstract ShapeType ShapeType { get; }
    }
}
