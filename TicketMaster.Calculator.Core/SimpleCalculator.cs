
namespace TicketMaster.Calculator.Core
{
    public class SimpleCalculator
    {
        public UnaryExpression Evaluate(string input, MathFormat inputFormat = MathFormat.Decimal)
        {
            MathExpression expression;

            if (input.Contains("+"))
            {
                expression = new AddExpression(input, inputFormat);
            }
            else if (input.Contains("/"))
            {
                expression = new DivideExpression(input, inputFormat);
            }
            else if (input.Contains("*"))
            {
                expression = new MultiplyExpression(input, inputFormat);
            }
            else if (input.Contains("-"))
            {
                expression = new SubtractExpression(input, inputFormat);
            }
            else
            {
                expression = new UnaryExpression(input, inputFormat);
            }

            return expression.Evaluate();
        }
    }
}