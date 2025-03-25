using Exercises._2___Structural.Section_8___Composite;

namespace Tests.Tests._2___Structural._8___Composite_Tests
{
    public class Composite
    {
        // Composite
        [Fact]
        public void AssertCompositeTester()
        {
            // Arrange
            SingleValue value1 = new SingleValue() { Value = 12 };

            ManyValues manyValues = new ManyValues();

            // Act
            manyValues.Add(10);
            manyValues.Add(17);
            manyValues.Add(9);

            // Assert
            Assert.Equal(36, manyValues.Sum());
            Assert.Equal(48, new List<IValueContainer> { value1, manyValues }.Sum());
        }
    }
}
