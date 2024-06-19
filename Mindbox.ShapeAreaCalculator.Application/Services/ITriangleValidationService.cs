namespace Mindbox.ShapeAreaCalculator.Application.Services
{
    public interface ITriangleValidationService
    {
        void Validate(double sideA, double sideB, double sideC);
    }
}
