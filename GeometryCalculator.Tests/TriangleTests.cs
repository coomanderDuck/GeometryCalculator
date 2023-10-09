using GeometryCalculator.Models;
using System.ComponentModel.DataAnnotations;

namespace GeometryCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ValidSides_ReturnsCorrectResult()
        {
            var triangle = new Triangle(3, 4, 5);

            var actualArea = triangle.CalculateArea();

            Assert.Equal(6, actualArea);
        }

        [Fact]
        public void CalculateArea_NonValidSides_ShouldThrowValidationException()
        {
            var triangle = new Triangle(10, 1, 2);

            var exception = Assert.Throws<ValidationException>(() => triangle.CalculateArea());
            Assert.Equal("Треугольник с такими сторонами не существует.", exception.Message);
        }

        [Fact]
        public void CalculateArea_NonPositiveSideLength_ShouldThrowValidationException()
        {
            var triangle = new Triangle(0, -4, 5);

            var exception = Assert.Throws<ValidationException>(() => triangle.CalculateArea());
            Assert.Equal("Длины сторон треугольника должны быть положительными числами.", exception.Message);
        }
    }
}
