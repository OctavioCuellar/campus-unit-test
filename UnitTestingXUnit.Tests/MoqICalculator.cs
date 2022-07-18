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
            mock.Setup(m => m.Add(2, 2)).Returns(4);

            // Assert
            Assert.Equal(4, mock.Object.Add(2, 2));

        }

        [Fact]
        public void Sub_ShouldSubstractSimpleValues()
        {
            // Arrange
            var mock = new Mock<ICalculator>();

            // Act
            mock.Setup(m => m.Sub(10, 4)).Returns(6);

            // Assert
            Assert.Equal(6, mock.Object.Sub(10, 4));

        }

        [Fact]
        public void Mul_ShouldMultiplySimpleValues()
        {
            // Arrange
            var mock = new Mock<ICalculator>();

            // Act
            mock.Setup(m => m.Mul(2, 2)).Returns(4);

            // Assert
            Assert.Equal(4, mock.Object.Mul(2, 2));

        }

        [Fact]
        public void Div_ShouldDivideSimpleValues()
        {
            // Arrange
            var mock = new Mock<ICalculator>();

            // Act
            mock.Setup(m => m.Div(10, 5)).Returns(2);

            // Assert
            Assert.Equal(2, mock.Object.Div(10, 5));

        }

    }
}
