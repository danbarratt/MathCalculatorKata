namespace TicketMaster.Calculator.Core
{
    public abstract class MathExpression
    {
        public abstract UnaryExpression Evaluate();
    }

    public enum MathFormat
    {
        Decimal = 0,
        Octal,
    }
}