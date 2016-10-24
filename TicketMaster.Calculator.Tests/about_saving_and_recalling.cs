using System.ComponentModel.Design;
using System.Linq;
using NUnit.Framework;
using TicketMaster.Calculator.Core;

namespace TicketMaster.Calculator.Tests
{
    public class about_saving_and_recalling
    {

        [Test]
        public void when_no_expressions_have_been_saved()
        {
            SimpleCalculator calculator = new SimpleCalculator();

            Assert.That(calculator.SavedExpressions, Is.Empty);
        }

        [Test]
        public void when_one_expression_has_been_saved()
        {
            SimpleCalculator calculator = new SimpleCalculator();

            calculator.SaveExpression("2 + 2");

            Assert.That(calculator.SavedExpressions, Is.Not.Empty);

            Assert.That(calculator.SavedExpressions().Count(), Is.EqualTo(1));

            Assert.That(calculator.SavedExpressions().First().InputString, Is.EqualTo("2 + 2"));
        }

    }
}
