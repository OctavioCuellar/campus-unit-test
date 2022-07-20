using Xunit;
using Moq;
using Calculators;

namespace UnitTestingXUnit.Tests
{
    public class MoqSeriesTest
    {
        [Fact]
        public void FactorialShouldFactorSimpleValue()
        {
            // Arrange
            int expected = 5040;
            int number = 7;
            Mock<ICalculator> calculatorMock = new Mock<ICalculator>();

            calculatorMock.Setup(m => m.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a * b);
            Series series = new Series(calculatorMock.Object);

            // Act
            int actual = series.Factorial(number);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FibonacciShouldFiboSimpleValue()
        {
            // Arrange
            int expected = 13;
            int number = 7;
            Mock<ICalculator> calculatorMock = new Mock<ICalculator>();

            calculatorMock.Setup(m => m.Add(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a + b);
            Series series = new Series(calculatorMock.Object);

            // Act
            int actual = series.Fibonacci(number);

            // Assert
            Assert.Equal(expected, actual);

        }

    }
}
