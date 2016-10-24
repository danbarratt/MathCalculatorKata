Calculator App
==============

An explanation of your design
-----------------------------

The main SimpleCalculator application accepts input calculations from the user and evaluates to a single numerical result. 
Each calculation is parsed into one of a number of expresion classes, which know how to perform a specific maths operation.

The following expressions have been written to satisfy the requirements:

MathExpression
  - UnaryExpression
  - BinaryExpression
    - AddExpression
    - SubtractExpression
    - MultiplyExpression 
    - DivideExpression
	- RootExpression
	- ExponentExpression

Each expression can be evaluated to a single unary expression, which can be represented in a numerical output format (eg. decimal, binary, octet).

For storing and retrieving calculations, the calculator is able to use an ExpressionRepository for storing state.


An explanation of how your solution meets the requirements
---------------------------------------------------------

I'm kinda hoping that the unit tests explain what the program is capable of. 
The unit test suite specifically includes the example calculations from the requirements documents.


Instructions how to build and run your solution, including which tools you used
---------------------------------------------------------

This project was written using VisualStudio Community 2015 and Resharper 2016.2

To build the solution, use Visual Studio 2015 or the following command line:
c:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe TicketMaster.Calculator.sln


A list of the assumptions you have made, where appropriate
----------------------------------------------------------

No user interface was specified in the requirements, so I've written the application as a pure C# library. 
This can be exposed to a user using a suitable user interface (eg. Windows Forms, ASP.Net, Web service, etc).

I've made the assumption that the user interface would accept calculations from the user as a string (eg "3 + 2"). 
The application will parse the input string and evaluate the expression to a specified output format (eg. binary, decimal, octed, etc.)

I've also assumed that the user will specify the format of the numbers in the input string (ie decimal vs binary vs octet). 
Based on the requirements, the input string "101" could be considered to be encoded in either decimal or binary format. The must must therefore specify the input format.


A list of any dependent external libraries you have used and the reasons for your choice
---------------------------------------------------------

NUnit.Framework - This is a unit test framework. This was used for TDD purposes.


Code Coverage
-------------

According to JetBrains dotCover tool, the TicketMaster.Calculator.Core project has 97% test coverage.