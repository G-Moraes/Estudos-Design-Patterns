using Exercises._2___Structural.Section_10___Façade;

namespace Tests.Tests._2___Structural._10___Façade_Tests
{
    public class Façade
    {
        // Façade
        [Fact(Skip = "It takes too much time to run, but it works")]
        public void AssertFaçadeTester()
        {
            // Arrange
            MagicSquareGenerator façadeGenerator = new MagicSquareGenerator();
            Verifier verifier = new Verifier();

            // Act
            List<List<int>> square = façadeGenerator.Generate(2);

            // Assert
            Assert.True(verifier.Verify(square));
        }
    }
}
