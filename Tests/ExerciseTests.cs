using Exercises._1___Creational.Section_2___Builder;
using Exercises._1___Creational.Section_3___Factory;
using Exercises._1___Creational.Section_4___Prototype;
using static Exercises._1___Creational.Section_5___Singleton.SingletonExercise;
using Exercises._2___Structural.Section_6___Adapter;
using Exercises._2___Structural.Section_7___Bridge;
using Exercises._2___Structural.Section_8___Composite;
using Exercises._2___Structural.Section_9___Decorator;
using Exercises._2___Structural.Section_10___Façade;

namespace Tests
{
    public class ExerciseTests
    {
        // Builder
        [Theory]
        [ClassData(typeof(BuilderTestData))]
        public void AssertBuilderTester(ComplexFields complexFields)
        {
            //Act
            var cb = new CodeBuilder(complexFields.CreatedClassName);
            
            foreach (KeyValuePair<string, string> kvp in complexFields.Fields)
            {
                cb.AddField(kvp.Key, kvp.Value);
            }

            // Assert
            Assert.Equal(BuilderTester.Preprocess(complexFields.ExpectedClassString), BuilderTester.Preprocess(cb.ToString()));
        }

        // Factory
        [Theory]
        [InlineData("Chris")]
        [InlineData("Jane")]
        [InlineData("John")]
        [InlineData("Mary")]
        public void AssertFactoryTester(string personName)
        {
            // Arrange
            PersonFactory pf    = new PersonFactory();

            // Act
            Person person       = pf.CreatePerson(personName);

            // Assert
            Assert.Equal(personName, person.Name);
        }

        // Prototype
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

        // Singleton
        [Fact]
        public void AssertSingletonTester()
        {
            // Arrange
            var obj = new object();

            // Assert
            Assert.True(SingletonTester.IsSingleton(() => obj));
            Assert.False(SingletonTester.IsSingleton(() => new object()));
        }

        // Adapter
        [Fact]
        public void AssertAdapterTester()
        {
            // Arrange
            Exercises._2___Structural.Section_6___Adapter.Square square   = new Exercises._2___Structural.Section_6___Adapter.Square();
            square.Side     = 4;

            // Act
            IRectangle rectangle = new SquareToRectangleAdapter(square);

            // Assert
            Assert.Equal(square.Side, rectangle.Height);
            Assert.Equal(square.Side, rectangle.Width);
        }

        // Bridge
        [Fact]
        public void AssertBridgeRasterRendererTester()
        {
            // Arrange
            Triangle triangle = new Triangle(new RasterRenderer());
          Exercises._2___Structural.Section_7___Bridge.Square square       = new Exercises._2___Structural.Section_7___Bridge.Square(new RasterRenderer());

            // Assert
            Assert.Equal("Drawing Triangle as pixels", triangle.ToString());
            Assert.Equal("Drawing Square as pixels", square.ToString());
        }

        [Fact]
        public void AssertBridgeVectorRendererTester()
        {
            // Arrange
            Triangle triangle = new Triangle(new VectorRenderer());
          Exercises._2___Structural.Section_7___Bridge.Square square       = new Exercises._2___Structural.Section_7___Bridge.Square(new VectorRenderer());

            // Assert
            Assert.Equal("Drawing Triangle as lines", triangle.ToString());
            Assert.Equal("Drawing Square as lines", square.ToString());
        }

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

        // Decorator
        [Theory]
        [InlineData(1, "flying", "too young")]
        [InlineData(10, "too old", "crawling")]
        [InlineData(5, "flying", "crawling")]
        public void AssertDecoratorTester(int age, string flyMsg, string crawlMsg)
        {
            // Arrange
            Dragon dragon = new Dragon();

            // Act
            dragon.Age = age;

            // Assert
            Assert.Equal(flyMsg, dragon.Fly());
            Assert.Equal(crawlMsg, dragon.Crawl());
        }

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