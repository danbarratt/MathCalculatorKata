using System.Diagnostics;
using Irony.Interpreter.Evaluator;

namespace TicketMaster.Calculator.Core
{
    public class SimpleCalculator
    {
        public ExpressionResult Evaluate(string expression)
        {
            ExpressionEvaluator evaluator = new ExpressionEvaluator(new MathsGrammar());

            object result = evaluator.Evaluate(expression);

            Debug.WriteLine("Evaluated <{0}> as <{1}> <{2}>", expression, result, result.GetType().Name);

            return new ExpressionResult(result);
        }
    }
}