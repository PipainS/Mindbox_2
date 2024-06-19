using Microsoft.AspNetCore.Mvc;
using Mindbox.ShapeAreaCalculator.Application.Services;
using Mindbox.ShapeAreaCalculator.Application.Services.Impl;
using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Mindbox.ShapeAreaCalculator.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShapesController : ControllerBase
    {
        private readonly IShapeFactory _shapeFactory;
        private readonly ICircleAreaCalculator _circleAreaCalculator;
        private readonly ITriangleAreaCalculator _triangleAreaCalculator;

        public ShapesController(
            IShapeFactory shapeFactory,
            ICircleAreaCalculator circleAreaCalculator,
            ITriangleAreaCalculator triangleAreaCalculator)
        {
            _shapeFactory = shapeFactory;
            _circleAreaCalculator = circleAreaCalculator;
            _triangleAreaCalculator = triangleAreaCalculator;
        }

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
