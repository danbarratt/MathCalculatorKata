using NUnit.Framework;

namespace TicketMaster.Calculator.Tests
{
    public class about_output_formats : CalculatorEvaluteTest
    {
        [Test]
        public void binary_expression_formatted_to_binary()
        {
            var result = EvaluateToExpressionResult("99 + 1");

            Assert.That(result.FormatBinary(), Is.EqualTo("1100100"));
        }

        [Test, Ignore("Cannot currently understand <octal> input formats")]
        public void unary_expression_formatted_to_octal()
        {
            var result = EvaluateToExpressionResult("20D");

            Assert.That(result.FormatOctal(), Is.EqualTo("1015"));
        }

        [Test, Ignore("Cannot currently understand <binary> input formats")]
        public void unary_expression_formatted_to_hexadecimal()
        {
            var result = EvaluateToExpressionResult("100111");

            Assert.That(result.FormatHexadecimal(), Is.EqualTo("27"));
        }
        
        [Test]
        public void binary_expression_formatted_to_octal()
        {
            var result = EvaluateToExpressionResult("654 - 546");

            Assert.That(result.FormatOctal(), Is.EqualTo("70"));
        }
    }
}