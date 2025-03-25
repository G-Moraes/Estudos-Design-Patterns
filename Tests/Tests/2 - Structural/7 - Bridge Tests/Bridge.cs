using Exercises._2___Structural.Section_7___Bridge;

namespace Tests.Tests._2___Structural._7___Bridge_Tests
{
    public class Bridge
    {
        // Bridge
        [Fact]
        public void AssertBridgeRasterRendererTester()
        {
            // Arrange
            Triangle triangle = new Triangle(new RasterRenderer());
            Exercises._2___Structural.Section_7___Bridge.Square square = new Exercises._2___Structural.Section_7___Bridge.Square(new RasterRenderer());

            // Assert
            Assert.Equal("Drawing Triangle as pixels", triangle.ToString());
            Assert.Equal("Drawing Square as pixels", square.ToString());
        }

        [Fact]
        public void AssertBridgeVectorRendererTester()
        {
            // Arrange
            Triangle triangle = new Triangle(new VectorRenderer());
            Exercises._2___Structural.Section_7___Bridge.Square square = new Exercises._2___Structural.Section_7___Bridge.Square(new VectorRenderer());

            // Assert
            Assert.Equal("Drawing Triangle as lines", triangle.ToString());
            Assert.Equal("Drawing Square as lines", square.ToString());
        }
    }
}
