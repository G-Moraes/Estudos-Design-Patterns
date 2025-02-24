using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Estudo_Design_Patterns.Exercises.Section_2___Builder
{
    public class FieldInformation
    {
        private const int indentSize = 2;
        public string FieldName, FieldType;

        public FieldInformation()
        {
            
        }

        public FieldInformation(string fieldName, string fieldType)
        {
            FieldType = fieldType;
            FieldName = fieldName;
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);

            sb.Append(new string(' ', indentSize * (indent + 1)));
            sb.Append($"{i}public {FieldType} {FieldName};\n");


            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }

    public class CodeBuilder
    {
        List<FieldInformation> root = new List<FieldInformation>();
        private readonly string ClassName;

        public CodeBuilder(string className)
        {
            this.ClassName = className;
        }

        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            bool found = false;

            FieldInformation toBeAddedField = new FieldInformation(fieldName, fieldType);

            foreach (FieldInformation fi in root)
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
                root.Add(toBeAddedField);
            }

            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("public class ").Append(this.ClassName).Append("\n");
            sb.Append("{\n");

            foreach (FieldInformation fi in root)
            {
                sb.Append(fi.ToString());
            }

            sb.Append("}\n");

            return sb.ToString();
        }
    }
}
