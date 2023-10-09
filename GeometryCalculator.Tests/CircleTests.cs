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
        public void CalculateArea_NonPositiveSideLength_ShouldThrowValidationException()
        {
            var circle = new Circle(-5);

            var exception = Assert.Throws<ValidationException>(() => circle.CalculateArea());
            Assert.Equal("Радиус должен быть положительным числом.", exception.Message);
        }
    }
}
