using NUnit.Framework;

namespace TicketMaster.Calculator.Tests
{
    public class about_decimal_multiplication : CalculatorEvaluteTest
    {
        [Test]
        public void divide_integer_by_integer()
        {
            Assert.That(EvaluateToValue("88 * 22"), Is.EqualTo(1936));
        }

        [Test]
        public void divide_integer_by_decimal()
        {
            Assert.That(EvaluateToValue("87 * 4.25"), Is.EqualTo(369.75));
        }

        [Test]
        public void divide_decimal_by_decimal()
        {
            Assert.That(EvaluateToValue("84.38 * 4.38"), Is.EqualTo(369.58).Within(0.01));
        }
    }
}