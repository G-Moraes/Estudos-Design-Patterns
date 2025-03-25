using Exercises._2___Structural.Section_9___Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests._2___Structural._9___Decorator_Tests
{
    public class Decorator
    {
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
    }
}
