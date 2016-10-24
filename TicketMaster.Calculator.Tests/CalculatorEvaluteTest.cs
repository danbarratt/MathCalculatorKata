using NUnit.Framework;
using TicketMaster.Calculator.Core;

namespace TicketMaster.Calculator.Tests
{
    [TestFixture]
    public abstract class CalculatorEvaluteTest
    {
        protected object EvaluateToValue(string expression)
        {
            return EvaluateToExpressionResult(expression).Result;
        }

        protected ExpressionResult EvaluateToExpressionResult(string expression)
        {
            return new SimpleCalculator().Evaluate(expression);
        }
    }
}