using System.Collections;
using System.Collections.Generic;

namespace MathCalculator.Core
{
    internal class ExpressionRepository : IEnumerable<MathExpression>
    {
        private List<MathExpression> _items = new List<MathExpression>();

        public void Add(MathExpression expression)
        {
            _items.Add(expression);
        }

        public IEnumerator<MathExpression> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}