namespace TicketMaster.Calculator.Core
{
    public abstract class MathExpression
    {
        public string InputString { protected set; get; }

        public MathFormat InputFormat { protected set; get; }
        
        public abstract UnaryExpression Evaluate();

        public static MathExpression Parse(string input, MathFormat inputFormat)
        {
            if (input.Contains("+"))
            {
                return new AddExpression(input, inputFormat);
            }

            if (input.Contains("/"))
            {
                return new DivideExpression(input, inputFormat);
            }

            if (input.Contains("*"))
            {
                return new MultiplyExpression(input, inputFormat);
            }

            if (input.Contains("-"))
            {
                return new SubtractExpression(input, inputFormat);
            }
            
            return new UnaryExpression(input, inputFormat);
        }
    }
}