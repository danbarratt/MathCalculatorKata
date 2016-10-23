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

    
    public class about_decimal_division : CalculatorEvaluteTest
    {
        [Ignore("WIP")]
        [Test]
        public void divide_integer_by_integer()
        {
            Assert.That(EvaluateWithCalculator("100 / 21"), Is.EqualTo(5.25));
        }

        // TEST: 100 / 21 	= 5.25
    }

    
    public class about_decimal_multiplication : CalculatorEvaluteTest
    {
        // TEST: "88 * 22" = 1936    
    }
}
