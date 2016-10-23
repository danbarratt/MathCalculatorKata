using NUnit.Framework;

namespace TicketMaster.Calculator.Tests
{
    public class about_decimal_division : CalculatorEvaluteTest
    {
        [Test]
        public void divide_integer_by_integer()
        {
            Assert.That(EvaluateWithCalculator("105 / 20"), Is.EqualTo(5.25));
        }

        [Test]
        public void divide_integer_by_decimal()
        {
            Assert.That(EvaluateWithCalculator("100 / 4.25"), Is.EqualTo(23.53).Within(0.01));
        }

        [Test]
        public void divide_decimal_by_decimal()
        {
            Assert.That(EvaluateWithCalculator("84.38 / 4.25"), Is.EqualTo(19.85).Within(0.01));
        }
    }
}