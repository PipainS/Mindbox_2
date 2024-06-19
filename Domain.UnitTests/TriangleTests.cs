using Mindbox.ShapeAreaCalculator.Application.Services.Impl;
using Mindbox.ShapeAreaCalculator.Application.Services;
using Mindbox.ShapeAreaCalculator.Domain.enums;
using Mindbox.ShapeAreaCalculator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitTests
{
    public class TriangleTests
    {
        private readonly IShapeFactory _shapeFactory;

        public TriangleTests()
        {
            var triangleValidationService = new TriangleValidationService();
            _shapeFactory = new ShapeFactory(circleValidationService: null, triangleValidationService);
        }

        [Fact]
        public void CreateTriangle_WithValidSides_ShouldSetSides()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;

            // Act
            var triangle = _shapeFactory.CreateTriangle(sideA, sideB, sideC);

            // Assert
            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
            Assert.Equal(ShapeType.Triangle, triangle.ShapeType);
        }

        [Fact]
        public void CreateTriangle_WithInvalidSides_ShouldThrowArgumentException()
        {
            // Arrange
            double sideA = 1.0;
            double sideB = 1.0;
            double sideC = 5.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _shapeFactory.CreateTriangle(sideA, sideB, sideC));
        }

        [Fact]
        public void IsRightAngled_WithRightAngledTriangle_ShouldReturnTrue()
        {
            // Arrange
            var triangle = new Triangle(3.0, 4.0, 5.0);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }

        [Fact]
        public void IsRightAngled_WithNonRightAngledTriangle_ShouldReturnFalse()
        {
            // Arrange
            var triangle = new Triangle(3.0, 4.0, 6.0);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.False(isRightAngled);
        }
    }
}
