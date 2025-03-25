using Exercises._1___Creational.Section_3___Factory;

namespace Tests.Tests._1___Creational._3___Factory_Tests
{
    public class Factory
    {
        // Factory
        [Theory]
        [InlineData("Chris")]
        [InlineData("Jane")]
        [InlineData("John")]
        [InlineData("Mary")]
        public void AssertFactoryTester(string personName)
        {
            // Arrange
            PersonFactory pf = new PersonFactory();

            // Act
            Person person = pf.CreatePerson(personName);

            // Assert
            Assert.Equal(personName, person.Name);
        }
    }
}
