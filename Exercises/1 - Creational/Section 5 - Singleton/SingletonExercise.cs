﻿namespace Exercises._1___Creational.Section_5___Singleton
{
    public class SingletonExercise
    {
        /*
        Since implementing a singleton is easy, you have a different challenge: write a method called IsSingleton(). This method takes a factory method that returns an object and it's up to you to determine whether or not that object is a singleton instance.
        */
        public class SingletonTester
        {
            public static bool IsSingleton(Func<object> func)
            {
                var obj1 = func();
                var obj2 = func();

                return ReferenceEquals(obj1, obj2);
            }
        }
    }
}
