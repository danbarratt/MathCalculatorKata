using System;
using System.Linq;

namespace MathCalculator.Core
{
    public abstract class BinaryExpression : MathExpression
    {
        protected BinaryExpression(string input, MathFormat inputFormat)
        {
            InputString = input;
            InputFormat = inputFormat;
        }

        protected double[] Parameters
        {
            get
            {
                var parameterStrings = InputString.Split(new string[] { Operator }, StringSplitOptions.None);

                Func<string, double> decimalSelector = param => string.IsNullOrWhiteSpace(param) 
                    ? 0d 
                    : Convert.ToDouble(Convert.ToDecimal(param));

                // TODO: Remove duplication with UnaryExpression constructor
                if (InputFormat == MathFormat.Octal)
                {
                    decimalSelector = paramString => Convert.ToInt32(paramString, 8);
                }
                
                return parameterStrings.Select(it => it.Trim()).Select(decimalSelector).ToArray();
            }
        }

        public abstract string Operator { get; }
    }
}