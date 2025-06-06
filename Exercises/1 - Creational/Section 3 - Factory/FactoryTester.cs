﻿using Exercises;

namespace Exercises._1___Creational.Section_3___Factory
{
    class FactoryTester : BaseTester
    {
        public override void Test()
        {
            PersonFactory pf = new PersonFactory();

            Person person = pf.CreatePerson("Anderson");
            Console.WriteLine(person.ToString());

            Person person2 = pf.CreatePerson("Davi");
            Console.WriteLine(person2.ToString());

            Person person3 = pf.CreatePerson("Calabreso");
            Console.WriteLine(person3.ToString());
        }
    }
}