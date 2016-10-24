using System;

namespace TicketMaster.Calculator.Core
{
    public class UnaryExpression : MathExpression
    {
        public object Result { get; }

        public UnaryExpression(object result, MathFormat inputFormat = MathFormat.Decimal)
        {
            if (result is double)
            {
                result = Math.Round((double)result, 10);
            }

            Result = result;
        }

        public string FormatBinary()
        {
            return Convert.ToString(Convert.ToInt32(Result), 2);
        }

        public string FormatOctal()
        {
            return Convert.ToString(Convert.ToInt32(Result), 8);
        }

        public string FormatDecimal()
        {
            return Convert.ToString(Result);
        }

        public string FormatHexadecimal()
        {
            throw new NotImplementedException();
        }

        public override UnaryExpression Evaluate()
        {
            return this;
        }
    }
}