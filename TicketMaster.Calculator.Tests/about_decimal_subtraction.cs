using NUnit.Framework;

namespace TicketMaster.Calculator.Tests
{
    public class about_decimal_subtraction : CalculatorEvaluteTest
    {
        [Test]
        public void simple_subtraction_of_integers()
        {
            Assert.That(EvaluateToValue("3 - 2"), Is.EqualTo(1));
        }

        [Test]
        public void subtract_decimal_from_integer()
        {
            Assert.That(EvaluateToValue("12 - 5.3844"), Is.EqualTo(6.6156));
        }

        [Test]
        public void subtract_integer_from_decimal()
        {
            Assert.That(EvaluateToValue("5.321 - 2"), Is.EqualTo(3.321));
        }

        [Test]
        public void subtract_decimal_from_decimal()
        {
            Assert.That(EvaluateToValue("6.3944 - 4.4837"), Is.EqualTo(1.9107));
        }
    }
}