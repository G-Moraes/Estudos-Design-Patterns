using Exercises._2___Structural.Section_6___Adapter;
namespace Tests.Tests._2___Structural._6___Adapter_Tests
{
    public class Adapter
    {
        // Adapter
        [Fact]
        public void AssertAdapterTester()
        {
            // Arrange
            Exercises._2___Structural.Section_6___Adapter.Square square = new Exercises._2___Structural.Section_6___Adapter.Square();
            square.Side = 4;

            // Act
            IRectangle rectangle = new SquareToRectangleAdapter(square);

            // Assert
            Assert.Equal(square.Side, rectangle.Height);
            Assert.Equal(square.Side, rectangle.Width);
        }
    }
}
