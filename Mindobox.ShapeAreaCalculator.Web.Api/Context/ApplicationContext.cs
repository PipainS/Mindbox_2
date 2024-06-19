using Mindbox.ShapeAreaCalculator.Application.Services;
using Mindbox.ShapeAreaCalculator.Application.Services.Impl;
using Mindbox.ShapeAreaCalculator.Application.Services.Impl.ShapeServices;

namespace Mindbox.ShapeAreaCalculator.Web.Api.Context
{
    public static class ApplicationContext
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IShapeFactory, ShapeFactory>();
            services.AddTransient<ICircleValidationService, CircleValidationService>();
            services.AddTransient<ITriangleValidationService, TriangleValidationService>();
            services.AddTransient<IShapeAreaCalculatorService, ShapeAreaCalculatorService>();
            services.AddTransient<ICircleAreaCalculator, CircleAreaCalculator>();
            services.AddTransient<ITriangleAreaCalculator, TriangleAreaCalculator>();
        }
    }
}
