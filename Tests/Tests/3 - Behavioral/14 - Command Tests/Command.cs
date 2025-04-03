using Exercises._3___Behavioral.Section_14___Command;
using CommandExercise = Exercises._3___Behavioral.Section_14___Command;

namespace Tests.Tests._3___Behavioral._14___Command_Tests
{
    public class Command
    {
        [Theory]
        [InlineData(100, 50, true)]
        [InlineData(50, 50, true)]
        [InlineData(0, 50, false)]
        [InlineData(100, 1000, false)]
        public void AssertCommand(int depositAmount, int withdrawAmount, bool success)
        {
            // Arrange
            Account account = new Account();

            // Act
            CommandExercise.Command depositCommand = new CommandExercise.Command() { Amount = depositAmount, TheAction = CommandExercise.Command.Action.Deposit };

            account.Process(depositCommand);

            CommandExercise.Command withdrawCommand = new CommandExercise.Command() { Amount = withdrawAmount, TheAction = CommandExercise.Command.Action.Withdraw };

            account.Process(withdrawCommand);

            // Assert
            Assert.Equal(success, withdrawCommand.Success);
        }
    }
}
