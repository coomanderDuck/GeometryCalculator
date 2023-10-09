using GeometryCalculator.Models;

namespace GeometryCalculator
{
    public static class GeometryCalculator
    {
        public static double CalculateArea<T>(this T shape)
            where T : Shape
        {
            shape.Validate();

            return shape.GetArea();
        }
    }
}
