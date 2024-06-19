using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Mindbox.ShapeAreaCalculator.Application.Services
{
    public interface ICircleAreaCalculator
    {
        double CalculateArea(Circle circle);
    }
}
