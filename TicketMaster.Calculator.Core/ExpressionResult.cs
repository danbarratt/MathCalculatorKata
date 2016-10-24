using System;

namespace TicketMaster.Calculator.Core
{
    public class ExpressionResult
    {
        public object Result { get; }

        public ExpressionResult(object result)
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

        public string FormatHexadecimal()
        {
            throw new NotImplementedException();
        }
    }
}