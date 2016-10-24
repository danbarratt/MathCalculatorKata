using NUnit.Framework;

namespace TicketMaster.Calculator.Tests
{
    public class about_decimal_root : CalculatorEvaluteTest
    {
        [Test]
        public void unary_root_of_integer()
        {
            Assert.That(EvaluateToValue("√9"), Is.EqualTo(3));
        }

        [Test]
        public void binary_root_of_integer_by_integer()
        {
            Assert.That(EvaluateToValue("3√64"), Is.EqualTo(4));
        }
    }
}