using Exercises;
using System;
namespace Exercises._2___Structural.Section_9___Decorator
{
    public class DecoratorTester : BaseTester
    {
        public override void Test()
        {
            var dragon = new Dragon();

            dragon.Age = 1;

            Console.WriteLine($"Dragon's Age: {dragon.Age}. Will the dragon fly? {dragon.Fly()}");
            Console.WriteLine($"Dragon's Age: {dragon.Age}. Will the dragon crawl? {dragon.Crawl()}");

            Console.WriteLine("\nSome time passed...\n");

            dragon.Age = 5;

            Console.WriteLine($"Dragon's Age: {dragon.Age}. Will the dragon fly? {dragon.Fly()}");
            Console.WriteLine($"Dragon's Age: {dragon.Age}. Will the dragon crawl? {dragon.Crawl()}");

            Console.WriteLine("\nSome time passed...\n");

            dragon.Age = 10;

            Console.WriteLine($"Dragon's Age: {dragon.Age}. Will the dragon fly? {dragon.Fly()}");
            Console.WriteLine($"Dragon's Age: {dragon.Age}. Will the dragon crawl? {dragon.Crawl()}");
        }
    }
}
