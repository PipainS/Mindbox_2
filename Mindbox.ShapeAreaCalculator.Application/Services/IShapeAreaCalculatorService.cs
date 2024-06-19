using Mindbox.ShapeAreaCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeAreaCalculator.Application.Services
{
    public interface IShapeAreaCalculatorService
    {
        double CalculateArea(Shape shape);
    }
}
