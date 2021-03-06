﻿using System;

namespace MathCalculator.Core
{
    public class UnaryExpression : MathExpression
    {
        public object Result { get; }

        public UnaryExpression(object value, MathFormat inputFormat = MathFormat.Decimal)
        {
            InputString = Convert.ToString(value);
            InputFormat = inputFormat;

            Result = value;

            if (value is string)
            {
                if (inputFormat == MathFormat.Binary)
                    Result = Convert.ToInt32((string)value, 2);
                
                else if (inputFormat == MathFormat.Octal)
                    Result = Convert.ToInt32((string)value, 8);

                else if (inputFormat == MathFormat.Hexadecimal)
                    Result = Convert.ToInt32((string) value, 16);

                else
                    Result = Convert.ToDouble((string) value);
            }
            
            else if (value is double)
            {
                Result = Math.Round((double) value, 10);
            }
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
            return Convert.ToString(Convert.ToInt32(Result), 16);
        }

        public override UnaryExpression Evaluate()
        {
            return this;
        }
    }
}