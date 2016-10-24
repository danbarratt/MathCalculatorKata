using NUnit.Framework;

namespace TicketMaster.Calculator.Tests
{
    public class about_decimal_exponent : CalculatorEvaluteTest
    {
        [Test]
        public void raise_integer_by_integer()
        {
            Assert.That(EvaluateToValue("5 exp 2"), Is.EqualTo(25));
        }

        [Test]
        public void raise_integer_by_decimal()
        {
            Assert.That(EvaluateToValue("3 exp 4.25"), Is.EqualTo(106.601995).Within(0.0000001));
        }
    }
}