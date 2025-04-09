using Exercises._1___Creational.Section_2___Builder;
using Exercises._1___Creational.Section_3___Factory;
using Exercises._1___Creational.Section_4___Prototype;
using Exercises._1___Creational.Section_5___Singleton;
using Exercises._2___Structural.Section_6___Adapter;
using Exercises._2___Structural.Section_7___Bridge;
using Exercises._2___Structural.Section_9___Decorator;
using Exercises._3___Behavioral.Section_17___Mediator;
using Exercises._3___Behavioral.Section_18___Memento;

namespace Exercises
{
    public class BaseTester
    {

        public static BaseTester LoadTester(int testerNumber)
        {
            BaseTester tester;

            switch (testerNumber)
            {
                case 2:
                    tester = new BuilderTester();
                    break;
                case 3:
                    tester = new FactoryTester();
                    break;
                case 4:
                    tester = new PrototypeTester();
                    break;
                case 5:
                    tester = new SingletonTester();
                    break;
                case 6:
                    tester = new AdapterTester();
                    break;
                case 7:
                    tester = new BridgeTester();
                    break;
                case 8:
                    throw new NotImplementedException();
                case 9:
                    tester = new DecoratorTester();
                    break;
                case 17:
                    tester = new MediatorTester();
                    break;
                case 18:
                    tester = new MementoTester();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return tester;
        }

        public virtual void Test()
        {
            throw new NotImplementedException();
        }
    }
}