using Exercises._3___Behavioral.Section_18___Memento;

namespace Tests.Tests._3___Behavioral._18___Memento_Tests
{
    public class Memento
    {
        [Fact]
        public void AssertMemento()
        {
            // Arrange
            var tokenMachina = new TokenMachine();

            // Act
            tokenMachina.AddToken(1);

            var memento = tokenMachina.AddToken(2);
            
            tokenMachina.AddToken(3);

            tokenMachina.Revert(memento);

            // Assert
            Assert.Equal(2, tokenMachina.Tokens.Count);
        }
    }
}
