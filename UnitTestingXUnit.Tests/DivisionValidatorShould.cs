using Xunit;
using Calculators;

namespace UnitTestingXUnit.Tests
{
    public class DivisionValidatorShould
    {
        [Fact]
        public void DivideByZeroRaiseError()
        {
            // Arrange
            int number = 100;
            int numberZero = 0;
            Calculator calculator = new Calculator();

            // Act

            // Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Div(number, numberZero));

        }
    }
}
