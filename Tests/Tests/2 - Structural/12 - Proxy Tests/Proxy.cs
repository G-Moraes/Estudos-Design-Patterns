
using Exercises._2___Structural.Section_12___Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests._2___Structural._12___Proxy_Tests
{
    public class Proxy
    {
        // Proxy
        [Theory]
        [InlineData(10, "too young")]
        [InlineData(16, "too young")]
        [InlineData(18, "drinking")]
        [InlineData(25, "drinking")]
        public void AssertProxyPersonCanDrink(int age, string expectedOutput)
        {
            // Arrange
            Person person = new Person() { Age = age };

            // Act
            ResponsiblePerson responsiblePerson = new ResponsiblePerson(person);

            // Assert
            Assert.Equal(expectedOutput, responsiblePerson.Drink());
        }

        // Proxy
        [Theory]
        [InlineData(10, "too young")]
        [InlineData(15, "too young")]
        [InlineData(16, "driving")]
        [InlineData(25, "driving")]
        public void AssertProxyPersonCanDrive(int age, string expectedOutput)
        {
            // Arrange
            Person person = new Person() { Age = age };

            // Act
            ResponsiblePerson responsiblePerson = new ResponsiblePerson(person);

            // Assert
            Assert.Equal(expectedOutput, responsiblePerson.Drive());
        }

        // Proxy
        [Fact]
        public void AssertProxyPersonCanDrinkAndDrive()
        {
            // Arrange
            Person person = new Person();

            // Act
            ResponsiblePerson responsiblePerson = new ResponsiblePerson(person);

            // Assert
            Assert.Equal("dead", responsiblePerson.DrinkAndDrive());
        }
    }
}
