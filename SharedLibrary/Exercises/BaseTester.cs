using SharedLibrary.Exercises._1___Creational.Section_2___Builder;
using SharedLibrary.Exercises._1___Creational.Section_3___Factory;
using SharedLibrary.Exercises._1___Creational.Section_4___Prototype;
using SharedLibrary.Exercises._1___Creational.Section_5___Singleton;
using SharedLibrary.Exercises._2___Structural.Section_6___Adapter;
using SharedLibrary.Exercises._2___Structural.Section_7___Bridge;

namespace SharedLibrary
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