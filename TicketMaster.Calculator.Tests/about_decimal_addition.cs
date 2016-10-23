using NUnit.Framework;

namespace TicketMaster.Calculator.Tests
{
    public class about_decimal_addition : CalculatorEvaluteTest
    {
        [Test]
        public void integer_addition()
        {
            Assert.That(EvaluateWithCalculator("2 + 3"), Is.EqualTo(5));
        }

        [Test]
        public void integer_addition_with_no_spaces()
        {
            Assert.That(EvaluateWithCalculator("1+1"), Is.EqualTo(2));
        }

        [Test]
        public void add_decimal_to_integer()
        {
            Assert.That(EvaluateWithCalculator("3.3827 + 14"), Is.EqualTo(17.3827));
        }

        [Test]
        public void add_decimal_to_decimal()
        {
            Assert.That(EvaluateWithCalculator("3.3827 + 43.28"), Is.EqualTo(46.6627));
        }
    }
}
