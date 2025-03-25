using Exercises._1___Creational.Section_4___Prototype;

namespace Tests.Tests._1___Creational._4___Prototype_Tests
{
    public class Prototype
    {
        // Prototype
        [Fact]
        public void AssertPrototypeTester()
        {
            // Arrange
            Point start = new Point();
            start.X = 10;
            start.Y = 5;

            Point end = new Point();
            end.X = 12;
            end.Y = 10;

            Line line1 = new Line();
            line1.Start = start;
            line1.End = end;

            // Act
            Line line2 = line1.DeepCopy();
            line2.End = new Point() { X = 17, Y = 15 };

            // Assert
            Assert.False(PrototypeTester.AreTwoLinesEqual(line1, line2));
        }
    }
}
