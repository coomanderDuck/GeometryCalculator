using System.ComponentModel.DataAnnotations;

namespace GeometryCalculator.Models
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius) : base(radius)
        {
            Radius = radius;
        }

        protected internal override double GetArea()
        {
            var pi = Math.PI;

            return pi * Math.Pow(Radius, 2);
        }

        protected internal override void Validate(params double[] args)
        {
            var radius = args[0];
            if (radius <= 0)
            {
                throw new ValidationException("Радиус должен быть положительным числом.");
            }
        }
    }
}
