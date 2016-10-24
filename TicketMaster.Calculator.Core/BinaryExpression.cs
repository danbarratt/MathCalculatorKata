using System;
using System.Linq;

namespace TicketMaster.Calculator.Core
{
    public abstract class BinaryExpression : MathExpression
    {
        protected BinaryExpression(string input, MathFormat inputFormat)
        {
            InputString = input;
            InputFormat = inputFormat;
        }

        protected decimal[] Parameters
        {
            get
            {
                var parameterStrings = InputString.Split(Operator);

                Func<string, decimal> decimalSelector = Convert.ToDecimal;

                // TODO: Remove duplication with UnaryExpression constructor
                if (InputFormat == MathFormat.Octal)
                {
                    decimalSelector = paramString => Convert.ToInt32(paramString, 8);
                }
                
                return parameterStrings.Select(it => it.Trim()).Select(decimalSelector).ToArray();
            }
        }

        public abstract char Operator { get; }
    }
}