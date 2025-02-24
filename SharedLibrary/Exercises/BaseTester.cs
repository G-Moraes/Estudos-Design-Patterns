using Estudo_Design_Patterns.Exercises.Section_3___Factory;
using Estudo_Design_Patterns.Exercises.Section_4___Prototype;
using SharedLibrary.Exercises.Structural.Section_6___Adapter;

namespace Estudo_Design_Patterns
{
    public class BaseTester
    {

        public static BaseTester LoadTester(int testerNumber)
        {
            BaseTester tester;

            switch (testerNumber)
            {
                case 2:
                    tester = new FactoryTester();
                    break;
                case 3:
                    tester = new FactoryTester();
                    break;
                case 4:
                    tester = new PrototypeTester();
                    break;
                case 5:
                    throw new NotImplementedException();
                case 6:
                    tester = new AdapterTester();
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