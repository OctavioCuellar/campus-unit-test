using Xunit;
using Moq;
using Calculators;

namespace UnitTestingXUnit.Tests
{

    public class MoqICalculator
    {
        [Fact]
        public void Add_ShouldAddSimpleValues()
        {
            // Arrange
            var mock = new Mock<ICalculator>();

            // Act
            mock.Setup(m => m.Add(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a + b);

            // Assert
            Assert.Equal(4, mock.Object.Add(2, 2));

        }

        [Fact]
        public void Sub_ShouldSubstractSimpleValues()
        {
            // Arrange
            var mock = new Mock<ICalculator>();

            // Act
            mock.Setup(m => m.Sub(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a - b);

            // Assert
            Assert.Equal(6, mock.Object.Sub(10, 4));

        }

        [Fact]
        public void Mul_ShouldMultiplySimpleValues()
        {
            // Arrange
            var mock = new Mock<ICalculator>();

            // Act
            mock.Setup(m => m.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a * b);

            // Assert
            Assert.Equal(4, mock.Object.Mul(2, 2));

        }

        [Fact]
        public void Div_ShouldDivideSimpleValues()
        {
            // Arrange
            var mock = new Mock<ICalculator>();

            // Act
            mock.Setup(m => m.Div(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a / b);

            // Assert
            Assert.Equal(2, mock.Object.Div(10, 5));

        }

    }
}
