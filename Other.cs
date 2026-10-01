using NUnit.Framework;

namespace CodepadTestSample.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CalculateTotal_Should_Return_Price_Multiplied_By_Quantity()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateTotal(10, 5);

            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void CalculateDiscount_Should_Return_No_Discount_For_Less_Than_100_Items()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateDiscount(50);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDiscount_Should_Return_10_Percent_For_100_Items()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateDiscount(100);

            Assert.That(result, Is.EqualTo(0.10));
        }

        [Test]
        public void CalculateDiscount_Should_Return_20_Percent_For_1000_Items()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateDiscount(1000);

            Assert.That(result, Is.EqualTo(0.20));
        }

        [Test]
        public void CalculateFinalTotal_Should_Apply_Discount()
        {
            var calculator = new Calculator();

            var result = calculator.CalculateFinalTotal(10, 100);

            Assert.That(result, Is.EqualTo(900));
        }
    }
}
