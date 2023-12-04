using System.ComponentModel.DataAnnotations;

namespace GeometryCalculator.Models
{
    public class Triangle : Shape
    {
        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        protected internal override double GetArea()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            var isRightTriangle = IsRightTriangle(sides);
            if (isRightTriangle)
            {
                return sides[0] * sides[1] / 2;
            }

            var s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        private bool IsRightTriangle(double[] sides)
        {
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        protected internal override void Validate(params double[] args)
        {
            var sideA = args[0];
            var sideB = args[1];
            var sideC = args[2];
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ValidationException("Длины сторон треугольника должны быть положительными числами.");
            }

            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ValidationException("Треугольник с такими сторонами не существует.");
            }
        }

        private bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
    }
}
