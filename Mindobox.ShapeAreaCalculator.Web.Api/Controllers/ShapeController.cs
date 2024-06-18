using Microsoft.AspNetCore.Mvc;
using Mindbox.ShapeAreaCalculator.Application.Services.Impl;
using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Mindbox.ShapeAreaCalculator.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapeController : ControllerBase
    {
        private readonly ShapeAreaCalculatorService _service;

        public ShapeController(ShapeAreaCalculatorService service)
        {
            _service = service;
        }

        [HttpGet("circle/area")]
        public ActionResult<double> GetCircleArea(double radius)
        {
            var circle = new Circle(radius);
            return _service.CalculateArea(circle);
        }

        [HttpGet("triangle/area")]
        public ActionResult<double> GetTriangleArea(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return _service.CalculateArea(triangle);
        }
    }
}
