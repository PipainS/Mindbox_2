using Mindbox.ShapeAreaCalculator.Application.Services;
using Mindbox.ShapeAreaCalculator.Application.Services.Impl;
using Mindbox.ShapeAreaCalculator.Domain.enums;
using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Domain.UnitTests
{
    public class CircleTests
    {
        private readonly IShapeFactory _shapeFactory;

        public CircleTests()
        {
            var circleValidationService = new CircleValidationService();
            _shapeFactory = new ShapeFactory(circleValidationService, triangleValidationService: null);
        }

        [Fact]
        public void CreateCircle_WithValidRadius_ShouldSetRadius()
        {
            // Arrange
            double radius = 5.0;

            // Act
            var circle = _shapeFactory.CreateCircle(radius);

            // Assert
            Assert.Equal(radius, circle.Radius);
            Assert.Equal(ShapeType.Circle, circle.ShapeType);
        }

        [Fact]
        public void CreateCircle_WithInvalidRadius_ShouldThrowArgumentException()
        {
            // Arrange
            double radius = -5.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _shapeFactory.CreateCircle(radius));
        }
    }
}