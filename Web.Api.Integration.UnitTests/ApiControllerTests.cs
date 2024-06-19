using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace Web.Api.Integration.UnitTests
{
    public class ApiControllerTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client = factory.CreateClient();

        [Fact]
        public async Task GetCircleArea_ValidRadius_ShouldReturnCorrectArea()
        {
            // Arrange
            double radius = 5.0;
            var url = $"/api/shapes/circle/area?radius={radius}";

            // Act
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var area = await response.Content.ReadFromJsonAsync<double>();

            // Assert
            Assert.Equal(Math.PI * Math.Pow(radius, 2), area, 5);
        }

        [Fact]
        public async Task GetTriangleArea_ValidSides_ShouldReturnCorrectArea()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            var url = $"/api/shapes/triangle/area?sideA={sideA}&sideB={sideB}&sideC={sideC}";

            // Act
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var area = await response.Content.ReadFromJsonAsync<double>();

            // Assert
            double s = (sideA + sideB + sideC) / 2;
            double expectedArea = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            Assert.Equal(expectedArea, area, 5);
        }
    }
}