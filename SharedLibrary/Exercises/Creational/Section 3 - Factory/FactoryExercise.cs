namespace Estudo_Design_Patterns.Exercises.Section_3___Factory
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(string name, int id)
        {
            Name    = name;
            Id      = id;
        }

        public override string ToString()
        {
            return new string($"Name:{Name}, Id:{Id}");
        }
    }

    public class PersonFactory
    {
        public static int internalId = 0;
        public Person CreatePerson(string name)
        {
            Person person = new Person(name, internalId);

            internalId++;

            return person;
        }
    }
}
