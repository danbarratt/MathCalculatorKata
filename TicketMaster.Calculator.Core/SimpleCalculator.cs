
using System.Collections.Generic;

namespace TicketMaster.Calculator.Core
{
    public class SimpleCalculator
    {
        private ExpressionRepository _repository = new ExpressionRepository();

        public MathExpression Parse(string input, MathFormat inputFormat = MathFormat.Decimal)
        {
            return MathExpression.Parse(input, inputFormat);
        }

        public UnaryExpression Evaluate(string input, MathFormat inputFormat = MathFormat.Decimal)
        {
            MathExpression expression = Parse(input, inputFormat);
            
            return expression.Evaluate();
        }

        public IEnumerable<MathExpression> SavedExpressions()
        {
            return _repository;
        }

        public void SaveExpression(string expression)
        {
            _repository.Add(Parse(expression));
        }
    }
}