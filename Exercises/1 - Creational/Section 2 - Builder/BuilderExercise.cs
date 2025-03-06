using System.Text;

namespace Exercises._1___Creational.Section_2___Builder
{
    /*

    You are asked to implement the Builder design pattern for rendering simple chunks of code. Sample use of the builder you are asked to create:

    var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");

    Console.WriteLine(cb);

    The expected output of the above code is:

    public class Person
    {
      public string Name;
      public int Age;
    }

    Please observe the same placement of curly braces and use two-space indentation.

    */

    public class FieldInformation
    {
        public string FieldName, FieldType;

        public FieldInformation(string fieldName, string fieldType)
        {
            FieldName = fieldName;
            FieldType = fieldType;
        }

        public override string ToString()
        {
            return $"public {FieldType} {FieldName}";
        }
    }

    public class Class
    {
        public string Name;
        public List<FieldInformation> Fields = new List<FieldInformation>();

        public Class()
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            
            sb.AppendLine($"public class {Name}").AppendLine("{");

            foreach (var field in Fields)
            {
                sb.AppendLine($"  {field};");
            }

            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class CodeBuilder
    {
        private Class createdClass = new Class();

        public CodeBuilder(string className)
        {
            createdClass.Name = className;
        }

        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            bool found = false;

            FieldInformation toBeAddedField = new FieldInformation(fieldName, fieldType);

            foreach (FieldInformation fi in createdClass.Fields)
            {
                if(String.IsNullOrEmpty(fi.FieldName) || 
                   String.IsNullOrEmpty(fi.FieldType) ||
                   !(fi.FieldName.Equals(fieldName, StringComparison.OrdinalIgnoreCase) && fi.FieldType.Equals(fieldType, StringComparison.OrdinalIgnoreCase)))
                {
                    continue;
                }

                found = true;
                break;
            }

            if (!found)
            {
                createdClass.Fields.Add(toBeAddedField);
            }

            return this;
        }

        public override string ToString()
        {
            return createdClass.ToString();
        }
    }
}
