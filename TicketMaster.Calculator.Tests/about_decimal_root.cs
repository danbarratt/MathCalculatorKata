using NUnit.Framework;

namespace TicketMaster.Calculator.Tests
{
    public class about_decimal_root : CalculatorEvaluteTest
    {
        [Ignore("Calculator currently does not understand the 'square root' operator")]
        [Test]
        public void unary_root_of_integer()
        {
            Assert.That(EvaluateWithCalculator("√9"), Is.EqualTo(3));
        }

        [Ignore("Calculator currently does not understand the 'square root' operator")]
        [Test]
        public void binary_root_of_integer_by_integer()
        {
            Assert.That(EvaluateWithCalculator("3√64"), Is.EqualTo(4));
        }
    }
}