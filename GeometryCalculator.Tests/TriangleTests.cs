using GeometryCalculator.Models;
using System.ComponentModel.DataAnnotations;

namespace GeometryCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ValidSides_ReturnsCorrectResult()
        {
            var triangle = new Triangle(6, 9, 4);

            var actualArea = triangle.CalculateArea();

            Assert.Equal(9.5622957494526393, actualArea);
        }

        [Fact]
        public void CalculateArea_ValidSidesOfRightTriangle_ReturnsCorrectResult()
        {
            var triangle = new Triangle(3, 4, 5);

            var actualArea = triangle.CalculateArea();

            Assert.Equal(6, actualArea);
        }

        [Fact]
        public void Create_NoneValidSides_ShouldThrowValidationException()
        {
            var exception = Assert.Throws<ValidationException>(() => new Triangle(10, 1, 2));
            Assert.Equal("Треугольник с такими сторонами не существует.", exception.Message);
        }

        [Fact]
        public void CalculateArea_NonValidSides_ShouldThrowValidationException()
        {
            var exception = Assert.Throws<ValidationException>(() => new Triangle(10, 1, 2));
            Assert.Equal("Треугольник с такими сторонами не существует.", exception.Message);
        }

        [Fact]
        public void Create_NonPositiveSideLength_ShouldThrowValidationException()
        {
            var exception = Assert.Throws<ValidationException>(() => new Triangle(0, -4, 5));
            Assert.Equal("Длины сторон треугольника должны быть положительными числами.", exception.Message);
        }
    }
}
