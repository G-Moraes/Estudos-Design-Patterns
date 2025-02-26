using System.Collections;

namespace Tests
{
    public class ComplexFields
    {
        public string ExpectedClassString;
        public string CreatedClassName;        
        public Dictionary<string, string> Fields = new Dictionary<string, string>();
    }

    public class BuilderTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ComplexFields
                {
                    ExpectedClassString = "public class Foo\n{\n}",
                    CreatedClassName = "Foo",
                }
            };

            yield return new object[]
            {
                new ComplexFields
                {
                    ExpectedClassString =
            @"public class Person
{
  public string Name;
  public int Age;
}",
                    CreatedClassName = "Person",
                    Fields = new Dictionary<string, string>
                    {
                        { "Name", "string" },
                        { "Age", "int" }
                    }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}