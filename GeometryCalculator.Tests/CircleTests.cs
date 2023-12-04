using GeometryCalculator.Models;
using System.ComponentModel.DataAnnotations;

namespace GeometryCalculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ValidSides_ReturnsCorrectResult()
        {
            var circle = new Circle(5);

            var actualArea = circle.CalculateArea();

            Assert.Equal(78.54, actualArea, 2);
        }

        [Fact]
        public void Create_NonPositiveSideLength_ShouldThrowValidationException()
        {
            var exception = Assert.Throws<ValidationException>(() => new Circle(-5));
            Assert.Equal("Радиус должен быть положительным числом.", exception.Message);
        }
    }
}
