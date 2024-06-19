using Mindbox.ShapeAreaCalculator.Application.Services.Impl;
using Mindbox.ShapeAreaCalculator.Application.Services.Impl.ShapeServices;
using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Application.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculateArea_WithCircle_ShouldReturnCorrectArea()
        {
            // Arrange
            var circle = new Circle(5.0);
            var circleCalculator = new CircleAreaCalculator();

            // Act
            var area = circleCalculator.CalculateArea(circle);

            // Assert
            Assert.Equal(Math.PI * 25, area, 10);
        }

        [Fact]
        public void CalculateArea_WithTriangle_ShouldReturnCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3.0, 4.0, 5.0);
            var triangleCalculator = new TriangleAreaCalculator();

            // Act
            var area = triangleCalculator.CalculateArea(triangle);

            // Assert
            Assert.Equal(6.0, area, 10);
        }

        [Fact]
        public void ShapeAreaCalculatorService_CalculateArea_WithCircle_ShouldReturnCorrectArea()
        {
            // Arrange
            var circle = new Circle(5.0);
            var circleCalculator = new CircleAreaCalculator();
            var triangleCalculator = new TriangleAreaCalculator();
            var service = new ShapeAreaCalculatorService(circleCalculator, triangleCalculator);

            // Act
            var area = service.CalculateArea(circle);

            // Assert
            Assert.Equal(Math.PI * 25, area, 10);
        }

        [Fact]
        public void ShapeAreaCalculatorService_CalculateArea_WithTriangle_ShouldReturnCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3.0, 4.0, 5.0);
            var circleCalculator = new CircleAreaCalculator();
            var triangleCalculator = new TriangleAreaCalculator();
            var service = new ShapeAreaCalculatorService(circleCalculator, triangleCalculator);

            // Act
            var area = service.CalculateArea(triangle);

            // Assert
            Assert.Equal(6.0, area, 10);
        }
    }
}