using MathCalculator.Core;
using NUnit.Framework;

namespace MathCalculator.Tests
{
    [TestFixture]
    public abstract class CalculatorEvaluteTest
    {
        protected object EvaluateToValue(string expression)
        {
            return EvaluateToExpressionResult(expression).Result;
        }

        protected UnaryExpression EvaluateToExpressionResult(string expression, MathFormat inputFormat = MathFormat.Decimal)
        {
            return new SimpleCalculator().Evaluate(expression, inputFormat);
        }
    }
}