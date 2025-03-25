using Exercises._2___Structural.Section_11___Flyweight;

namespace Tests.Tests._2___Structural._11___Flyweight_Tests
{
    public class Flyweight
    {
        // Flyweight
        [Theory]
        [InlineData("alpha beta gamma", 1, "alpha BETA gamma")]
        [InlineData("this is a test string input", 3, "this is a TEST string input")]
        public void AssertFlyweightTester(string originalString, int capitalizeIndex, string capitalizedWordString)
        {
            // Arrange
            Sentence sentence = new Sentence(originalString);

            // Act
            sentence[capitalizeIndex].Capitalize = true;

            // Assert
            Assert.Equal(capitalizedWordString, sentence.ToString());
        }
    }
}
