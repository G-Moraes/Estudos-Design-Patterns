using Exercises._3___Behavioral.Section_20___Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests._3___Behavioral._20___Observer_Tests
{
    public class Observer
    {
        [Fact]
        public void AssertObserverMultipleRats()
        {
            // Arrange
            var game = new Game();
            var rat1 = new Rat(game);
            var rat2 = new Rat(game);
            var rat3 = new Rat(game);

            // Assert
            Assert.Equal(3, rat1.Attack);
            Assert.Equal(3, rat2.Attack);
            Assert.Equal(3, rat3.Attack);
        }

        [Fact]
        public void AssertObserverMultipleRatsRemoveOne()
        {
            // Arrange
            var game = new Game();
            var rat1 = new Rat(game);
            var rat2 = new Rat(game);
            var rat3 = new Rat(game);

            // Assert
            Assert.Equal(3, rat1.Attack);
            Assert.Equal(3, rat2.Attack);
            Assert.Equal(3, rat3.Attack);

            // Act
            rat2.Dispose();

            // Assert
            Assert.Equal(2, rat1.Attack);
            Assert.Equal(2, rat3.Attack);
        }
    }
}