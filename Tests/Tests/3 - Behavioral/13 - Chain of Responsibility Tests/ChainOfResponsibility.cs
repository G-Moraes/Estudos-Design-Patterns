using Exercises._3___Behavorial.Section_13___Chain_of_Responsibility;

namespace Tests.Tests._3___Behavioral._13___Chain_of_Responsibility_Tests
{
    public class ChainOfResponsibility
    {
        [Fact]
        public void AssertChainOfResponsibilityTester()
        {
            var game    = new Game();
            var goblin  = new Goblin(game);

            game.Creatures.Add(goblin);

            Assert.Equal(1, goblin.Attack);
            Assert.Equal(1, goblin.Defense);

            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);

            Assert.Equal(1, goblin.Attack);
            Assert.Equal(2, goblin.Defense);

            var goblin3 = new GoblinKing(game);
            game.Creatures.Add(goblin3);

            Assert.Equal(2, goblin.Attack);
            Assert.Equal(3, goblin.Defense);
        }
    }
}
