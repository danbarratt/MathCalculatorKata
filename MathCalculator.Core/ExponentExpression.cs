using System;

namespace MathCalculator.Core
{
    public class ExponentExpression : BinaryExpression
    {
        public ExponentExpression(string input, MathFormat inputFormat) : base(input, inputFormat)
        {
        }

        public override UnaryExpression Evaluate()
        {
            var theValue = Math.Pow(Parameters[0], Parameters[1]);

            return new UnaryExpression(theValue);
        }

        public override string Operator => "exp";
    }
}