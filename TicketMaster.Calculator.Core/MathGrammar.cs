using System;
using Irony.Interpreter.Ast;
using Irony.Interpreter.Evaluator;
using Irony.Parsing;

namespace TicketMaster.Calculator.Core
{
    internal class MathsGrammar : ExpressionEvaluatorGrammar
    {
        public MathsGrammar()
        {
            //    Irony expression evaluator. Case-insensitive. Supports big integers, float data types, variables, assignments,
            //    arithmetic operations, augmented assignments (+=, -=), strings with embedded expressions; 
            //    bool operations &,&&, |, ||; operator.

            // 1. Terminals
            var number = new NumberLiteral("number");
            number.DefaultIntTypes = new TypeCode[] { TypeCode.Double };

            var identifier = new IdentifierTerminal("identifier");
            
            var comma = ToTerm(",");

            var Expr = new NonTerminal("Expr"); //declare it here to use in template definition 

            var templateSettings = new StringTemplateSettings(); //by default set to Ruby-style settings 
            templateSettings.ExpressionRoot = Expr; //this defines how to evaluate expressions inside template

            
            
            this.SnippetRoots.Add(Expr);
            
            //--------------------------------------------------------------------------------------------------------

            // 2. Non-terminals
            var Term = new NonTerminal("Term");
            var BinExpr = new NonTerminal("BinExpr", typeof(BinaryOperationNode));
            var ParExpr = new NonTerminal("ParExpr");
            var UnExpr = new NonTerminal("UnExpr", typeof(UnaryOperationNode));
            var ArgList = new NonTerminal("ArgList", typeof(ExpressionListNode));
            var UnOp = new NonTerminal("UnOp");
            var BinOp = new NonTerminal("BinOp", "operator");
            var Statement = new NonTerminal("Statement");
            var Program = new NonTerminal("Program", typeof(StatementListNode));

            // 3. BNF rules
            Expr.Rule = Term | UnExpr | BinExpr ;
            Term.Rule = number | ParExpr | identifier;
            ParExpr.Rule = "(" + Expr + ")";
            
            UnOp.Rule = ToTerm("+") | "-" | "√";
            UnExpr.Rule = UnOp + Term + ReduceHere();

            BinExpr.Rule = Expr + BinOp + Expr;
            BinOp.Rule = ToTerm("+") | "-" | "*" | "/" | "**" | "==" | "<" | "<=" | ">" | ">=" | "!=" | "&&" | "||" | "&" | "|" | "√";
            Statement.Rule = Expr | Empty;
            ArgList.Rule = MakeStarRule(ArgList, comma, Expr);
            Program.Rule = MakePlusRule(Program, NewLine, Statement);

            this.Root = Program;       // Set grammar root

            // 4. Operators precedence
            RegisterOperators(10, "&", "&&", "|", "||");
            RegisterOperators(30, "+", "-");
            RegisterOperators(40, "*", "/");
            RegisterOperators(50, Associativity.Right, "**");

            // For precedence to work, we need to take care of one more thing: BinOp. 
            //For BinOp which is or-combination of binary operators, we need to either 
            // 1) mark it transient or 2) set flag TermFlags.InheritPrecedence
            // We use first option, making it Transient.  

            // 5. Punctuation and transient terms
            MarkPunctuation("(", ")", "?", ":", "[", "]");
            RegisterBracePair("(", ")");
            RegisterBracePair("[", "]");
            MarkTransient(Term, Expr, Statement, BinOp, UnOp, ParExpr);

            // 7. Syntax error reporting
            AddToNoReportGroup("(", "++", "--");
            AddToNoReportGroup(NewLine);
            AddOperatorReportGroup("operator");
            
            // 9. Language flags. 
            // Automatically add NewLine before EOF so that our BNF rules work correctly when there's no final line break in source
            // this.LanguageFlags = LanguageFlags.NewLineBeforeEOF | LanguageFlags.CreateAst | LanguageFlags.SupportsBigInt;
        }
    }
}