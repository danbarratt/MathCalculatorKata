namespace TicketMaster.Calculator.Core
{
    public class DivideExpression : BinaryExpression
    {
        public DivideExpression(string input, MathFormat inputFormat) : base(input, inputFormat)
        {
        }

        public override UnaryExpression Evaluate()
        {
            return new UnaryExpression(Parameters[0] / Parameters[1]);
        }

        public override string Operator => "/";
    }
}