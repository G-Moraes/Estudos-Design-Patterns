using Estudo_Design_Patterns.Exercises.Section_3___Factory;
using Estudo_Design_Patterns.Exercises.Section_4____Prototype;
using Estudo_Design_Patterns.Exercises.Section_4___Prototype;
using SharedLibrary.Exercises.Structural.Section_6___Adapter;
using static SharedLibrary.Exercises.Section_5___Singleton.SingletonExercise;

namespace Tests
{
    public class ExerciseTests
    {
        [Fact(Skip = "Not Implemented Yet")]
        public void AssertBuilderTester()
        {

        }

        [Fact]
        public void AssertFactoryTester()
        {
            // Arrange
            PersonFactory pf    = new PersonFactory();

            // Act
            Person person       = pf.CreatePerson("Anderson");

            // Assert
            Assert.Equal("Anderson", person.Name);
        }

        [Fact]
        public void AssertPrototypeTester()
        {
            // Arrange
            Point start = new Point();
            start.X     = 10;
            start.Y     = 5;

            Point end   = new Point();
            end.X       = 12;
            end.Y       = 10;

            Line line1  = new Line();
            line1.Start = start;
            line1.End   = end;

            // Act
            Line line2  = line1.DeepCopy();
            line2.End   = new Point() { X = 17, Y = 15 };

            // Assert
            Assert.False(PrototypeTester.AreTwoLinesEqual(line1, line2));
        }

        [Fact]
        public void AssertSingletonTester()
        {
            // Arrange
            var obj = new object();

            // Assert
            Assert.True(SingletonTester.IsSingleton(() => obj));
            Assert.False(SingletonTester.IsSingleton(() => new object()));
        }

        [Fact]
        public void AssertAdapterTester()
        {
            // Arrange
            Square square   = new Square();
            square.Side     = 4;

            // Act
            IRectangle rectangle = new SquareToRectangleAdapter(square);

            //Assert
            Assert.Equal(square.Side, rectangle.Height);
            Assert.Equal(square.Side, rectangle.Width);
        }
    }
}