[\[English\]](#Using_Unit_Tests_to_Test_a_Calculator) [\[Português\]](READMEP.md)
_______________________________________________________________________________________________________________________________________
# Using Unit Tests to Test a Calculator
This solution is made up of three projects:
1. Simple Calculator:
   A project that uses the four mathematical operations (Addition, Subtraction, Multiplication and Division) with integers. Saves the last three operations in a list, for history purposes.
2. XUnit Test:
   A project using the XUnit framework to test the four operations, the number divided by zero exception, and the operations history list.
3. NUnit Test:
   A project using the NUnit framework to test the four operations, the number divided by zero exception, and the operations history list.

## Objectives
The main objective is to use the XUnit and NUnit tools to test a simple calculator project.

XUnit commands:
   - [Fact]: Used to start a unit test block.
   - [Theory] and [InlineData]: Used to test a unit test block with a list of parameters, can repeat numerous calls with different values.
   - Assert.Equal: Tests whether an expected result is equal to the obtained result, if so the test is valid, otherwise invalid.

NUnit commands:
   - [Test]: Used to start a unit test block, run once.
   - [TestCase]: Used to test a unit test block with a list of parameters, can repeat numerous calls with different values.
   - Assert.AreEqual: Tests whether an expected result is equal to the obtained result, if so the test is valid, otherwise invalid.

## Differences between XUnit and NUnit
Both frameworks have the same purpose. What changes are the commands.

## Tools
- Visual Studio 2022
- .Net 7.0
- XUnit Framework
- NUnit Framewowrk
