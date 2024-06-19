using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeAreaCalculator.Application.Services.Impl
{
    public class CircleValidationService : ICircleValidationService
    {
        public void Validate(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero.", nameof(radius));
            }
        }
    }
}
