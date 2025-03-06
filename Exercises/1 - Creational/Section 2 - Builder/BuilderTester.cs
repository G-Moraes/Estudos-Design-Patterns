using Exercises;

namespace Exercises._1___Creational.Section_2___Builder
{
    public class BuilderTester : BaseTester
    {
        public static string Preprocess(string s)
        {
            return s.Trim().Replace("\r\n", "\n");
        }

        public override void Test()
        {
            string correctClassString = Preprocess(@"public class Person
{
  public string Name;
  public int Age;
}"
          );

            Console.WriteLine($"Correct string:\n\n{correctClassString}\n");

            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");

            Console.WriteLine($"CodeBuilder created the class string:\n\n{Preprocess(cb.ToString())}\nWhich was equal to correct string: {Preprocess(cb.ToString()).Equals(correctClassString)}");
        }
    }
}
