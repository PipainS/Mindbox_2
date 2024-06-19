using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeAreaCalculator.Application.Services.Impl
{
    public class TriangleValidationService : ITriangleValidationService
    {
        public void Validate(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("All sides must be greater than zero.");
            }

            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("The given sides do not form a valid triangle.");
            }
        }

        private static bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }
    }
}
