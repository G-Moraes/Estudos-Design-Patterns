using Exercises._1___Creational.Section_2___Builder;

namespace Tests.Tests._1___Creational._2___Builder_Tests

{
    public class Builder
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
    }
}
