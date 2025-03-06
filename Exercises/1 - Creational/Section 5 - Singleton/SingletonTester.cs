using Exercises;

namespace Exercises._1___Creational.Section_5___Singleton
{
    public class SingletonTester : BaseTester
    {
        public override void Test()
        {
            var obj = new object();
            Console.WriteLine($"Object {nameof(obj)} is singleton: {SingletonExercise.SingletonTester.IsSingleton(() => obj)}");
            Console.WriteLine($"Object {nameof(obj)} is singleton: {SingletonExercise.SingletonTester.IsSingleton(() => new object())}");
        }
    }
}
