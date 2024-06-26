﻿using Mindbox.ShapeAreaCalculator.Domain.Models;

namespace Mindbox.ShapeAreaCalculator.Application.Services.Impl.ShapeServices
{
    public class CircleAreaCalculator : ICircleAreaCalculator
    {
        public double CalculateArea(Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius; 
        }
    }
}
