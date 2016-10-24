using System;
using System.Linq;

namespace TicketMaster.Calculator.Core
{
    public abstract class BinaryExpression : MathExpression
    {
        private readonly string _input;
        private readonly MathFormat _inputFormat;

        protected BinaryExpression(string input, MathFormat inputFormat)
        {
            _input = input;
            _inputFormat = inputFormat;
        }

        protected decimal[] Parameters
        {
            get
            {
                var parameterStrings = _input.Split(Operator);

                Func<string, decimal> decimalSelector = Convert.ToDecimal;

                if (_inputFormat == MathFormat.Octal)
                {
                    decimalSelector = paramString => Convert.ToInt32(paramString, 8);
                }
                
                return parameterStrings.Select(it => it.Trim()).Select(decimalSelector).ToArray();
            }
        }

        public abstract char Operator { get; }
    }
}