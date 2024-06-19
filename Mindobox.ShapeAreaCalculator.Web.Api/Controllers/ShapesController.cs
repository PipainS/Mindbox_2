using Microsoft.AspNetCore.Mvc;
using Mindbox.ShapeAreaCalculator.Application.Services;

namespace Mindbox.ShapeAreaCalculator.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShapesController(
        IShapeFactory shapeFactory,
        ICircleAreaCalculator circleAreaCalculator,
        ITriangleAreaCalculator triangleAreaCalculator) : ControllerBase
    {
        private readonly IShapeFactory _shapeFactory = shapeFactory;
        private readonly ICircleAreaCalculator _circleAreaCalculator = circleAreaCalculator;
        private readonly ITriangleAreaCalculator _triangleAreaCalculator = triangleAreaCalculator;

        [HttpGet("circle/area")]
        public ActionResult<double> GetCircleArea(double radius)
        {
            var circle = _shapeFactory.CreateCircle(radius);
            var area = _circleAreaCalculator.CalculateArea(circle);
            return Ok(area);
        }

        [HttpGet("triangle/area")]
        public ActionResult<double> GetTriangleArea(double sideA, double sideB, double sideC)
        {
            var triangle = _shapeFactory.CreateTriangle(sideA, sideB, sideC);
            var area = _triangleAreaCalculator.CalculateArea(triangle);
            return Ok(area);
        }
    }
}
