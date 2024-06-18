using Mindbox.ShapeAreaCalculator.Application.Services;
using Mindbox.ShapeAreaCalculator.Application.Services.Impl;
using Mindbox.ShapeAreaCalculator.Application.Services.Impl.ShapeServices;

namespace Mindbox.ShapeAreaCalculator.Web.Api.Context
{
    public static class ApplicationContext
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ITriangleAreaCalculator, TriangleAreaCalculator>();
            services.AddScoped<ICircleAreaCalculator, CircleAreaCalculator>();
            services.AddScoped<ShapeAreaCalculatorService>();
        }
    }
}
