using NUnit.Framework;
using TicketMaster.Calculator.Core;

namespace TicketMaster.Calculator.Tests
{
    [TestFixture]
    public abstract class CalculatorEvaluteTest
    {
        protected object EvaluateWithCalculator(string expression)
        {
            return new SimpleCalculator().Evaluate(expression);
        }
    }
}