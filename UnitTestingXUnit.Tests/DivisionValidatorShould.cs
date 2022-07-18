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
            Calculator calculator = new Calculator();

            // Act

            // Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Div(100, 0));

        }
    }
}
