using Xunit;
using Calculators;

namespace UnitTestingXUnit.Tests
{

    public class CalculatorsValidatorShould
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void Add_SimpleValues()
        {
            // Arrange
            float expected = 5;

            // Act
            float actual = calculator.Add(2, 3);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Sub_SimpleValues()
        {
            // Arrange
            float expected = 10;

            // Act
            float actual = calculator.Sub(15, 5);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(-6, 50, -300)]
        [InlineData(25, 8, 200)]
        [InlineData(3.2, 12, 38.4)]
        [InlineData(float.MaxValue, 1, float.MaxValue)]
        public void Mul_SimpleValues(float x, float y, float expected)
        {
            // Arrange
            // Aqui podria estar la instancia de la clase

            // Act
            float actual = calculator.Mul(x, y);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(450, 5, 90)]
        [InlineData(450, 90, 5)]
        [InlineData(-120, 2, -60)]
        [InlineData(47.45, 3.8, 12.486842)]
        public void Div_SimpleValues(float x, float y, float expected)
        {
            // Arrange

            // Act
            float actual = calculator.Div(x, y);

            // Assert
            Assert.Equal(expected, actual);

        }

    }
}