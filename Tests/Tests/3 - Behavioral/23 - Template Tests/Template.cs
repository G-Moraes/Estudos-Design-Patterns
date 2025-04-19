using Exercises._3___Behavioral.Section_23___Template;

using static Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_23___Template.TemplateTestData;

namespace Tests.Tests._3___Behavioral._23___Template_Tests
{
    public class Template
    {
        [Theory]
        [ClassData(typeof(ImpasseTestData))]
        public void AssertImpasseTest(Creature c1, Creature c2, int expectedWinner)
        {
            var game = new TemporaryCardDamageGame(new[] { c1, c2 });
            Assert.Equal(expectedWinner, game.Combat(0, 1));
            Assert.Equal(expectedWinner, game.Combat(0, 1));
        }

        [Theory]
        [ClassData(typeof(TemporaryMurderTestData))]
        public void AssertTemporaryMurderTest(Creature c1, Creature c2, int expectedWinner)
        {
            var game = new TemporaryCardDamageGame(new[] { c1, c2 });
            Assert.Equal(expectedWinner, game.Combat(0, 1));
        }

        [Theory]
        [ClassData(typeof(DoubleMurderTestData))]
        public void AssertDoubleMurderTest(Creature c1, Creature c2, int expectedWinner)
        {
            var game = new TemporaryCardDamageGame(new[] { c1, c2 });
            Assert.Equal(expectedWinner, game.Combat(0, 1));
        }

        [Theory]
        [ClassData(typeof(PermanentDamageTestData))]
        public void AssertPermanentDamageDeathTest(Creature c1, Creature c2, int expectedFirstResult, int expectedSecondResult)
        {
            var game = new PermanentCardDamage(new[] { c1, c2 });
            Assert.Equal(expectedFirstResult, game.Combat(0, 1));
            Assert.Equal(expectedSecondResult, game.Combat(0, 1));
        }
    }
}
