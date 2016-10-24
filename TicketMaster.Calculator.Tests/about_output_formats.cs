using NUnit.Framework;
using TicketMaster.Calculator.Core;

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

        [Test]
        public void unary_expression_formatted_to_octal()
        {
            var result = EvaluateToExpressionResult("20D", MathFormat.Hexadecimal);

            Assert.That(result.FormatOctal(), Is.EqualTo("1015"));
        }

        [Test]
        public void unary_expression_formatted_to_hexadecimal()
        {
            var result = EvaluateToExpressionResult("100111", MathFormat.Binary);

            Assert.That(result.FormatHexadecimal(), Is.EqualTo("27"));
        }
        
        [Test]
        public void octal_binary_expression_formatted_to_decimall()
        {
            var result = EvaluateToExpressionResult("654 - 546", MathFormat.Octal);
            
            Assert.That(result.Result, Is.EqualTo(70));
        }
    }
}