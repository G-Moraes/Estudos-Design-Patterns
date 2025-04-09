using Exercises._3___Behavioral.Section_15___Interpreter;
using Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_15____Interpreter;

namespace Tests.Tests._3___Behavioral._15___Interpreter_Tests
{
    public class Interpreter
    {
        [Theory]
        [ClassData(typeof(InterpreterTestData))]
        public void AssertInterpreter(InterpreterComplexFields field)
        {
            // Arrange
            ExpressionProcessor ep = new ExpressionProcessor();

            // Act
            if (field.Variables.Count > 0)
            {
                ep.Variables = field.Variables;
            }

            int result = ep.Calculate(field.Expression);

            // Assert
            Assert.Equal(field.ExpectedValue, result);
        }
    }
}
