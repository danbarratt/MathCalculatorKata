using System;
using System.Diagnostics;
using Irony.Interpreter.Evaluator;

namespace TicketMaster.Calculator.Core
{
    public class SimpleCalculator
    {
        public object Evaluate(string expression)
        {
            ExpressionEvaluator evaluator = new ExpressionEvaluator(new MathsGrammar());

            object result = evaluator.Evaluate(expression);

            if (result is double)
            {
                result = Math.Round((double) result, 10);
            }

            Debug.WriteLine("Evaluated <{0}> as <{1}> <{2}>", expression, result, result.GetType().Name);

            return result;
        }
    }
}