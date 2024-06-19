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
