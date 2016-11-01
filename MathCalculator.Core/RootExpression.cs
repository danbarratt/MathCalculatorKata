using System;

namespace MathCalculator.Core
{
    public class RootExpression : BinaryExpression
    {
        public RootExpression(string input, MathFormat inputFormat) : base(input, inputFormat)
        {
        }

        public override UnaryExpression Evaluate()
        {
            // If the exponent has been omitted, then we're acruallt performing a square root (eg. √9)
            var exponent = Parameters[0] == 0.0d ? 2 : Parameters[0];
            
            var theValue = Math.Pow(Parameters[1], 1d / exponent);

            return new UnaryExpression(theValue);
        }

        public override string Operator => "√";
    }
}