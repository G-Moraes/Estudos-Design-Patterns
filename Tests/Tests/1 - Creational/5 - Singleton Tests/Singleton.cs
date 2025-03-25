using static Exercises._1___Creational.Section_5___Singleton.SingletonExercise;

namespace Tests.Tests._1___Creational._5___Singleton_Tests
{
    public class Singleton
    {
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
    }
}
