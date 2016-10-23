using NUnit.Framework;

namespace TicketMaster.Calculator.Tests
{
    public class about_decimal_subtraction : CalculatorEvaluteTest
    {
        [Test]
        public void simple_subtraction_of_integers()
        {
            Assert.That(EvaluateWithCalculator("3 - 2"), Is.EqualTo(1));
        }

        [Test]
        public void subtract_decimal_from_integer()
        {
            Assert.That(EvaluateWithCalculator("12 - 5.3844"), Is.EqualTo(6.6156));
        }

        [Test]
        public void subtract_integer_from_decimal()
        {
            Assert.That(EvaluateWithCalculator("5.321 - 2"), Is.EqualTo(3.321));
        }

        [Test]
        public void subtract_decimal_from_decimal()
        {
            Assert.That(EvaluateWithCalculator("6.3944 - 4.4837"), Is.EqualTo(1.9107));
        }
    }
}