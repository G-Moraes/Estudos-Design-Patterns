using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._3___Behavioral.Section_19___Null_Object
{
    /*
        In this example, we have a class Account that is very tightly coupled to an ILog... it also breaks SRP by performing all sorts of weird checks in SomeOperation().

        Your mission, should you choose to accept it, is to implement a NullLog class that can be fed into an Account and that doesn't throw any exceptions.
    */

    public interface ILog
    {
        // maximum # of elements in the log
        int RecordLimit { get; }

        // number of elements already in the log
        int RecordCount { get; set; }

        // expected to increment RecordCount
        void LogInfo(string message);
    }

    public class Account
    {
        private ILog log;

        public Account(ILog log)
        {
            this.log = log;
        }

        public void SomeOperation()
        {
            int c = log.RecordCount;
            log.LogInfo("Performing an operation");
            if (c + 1 != log.RecordCount)
                throw new Exception();
            if (log.RecordCount >= log.RecordLimit)
                throw new Exception();
        }
    }

    public class NullLog : ILog
    {
        private int _recordCount = 0;

        public int RecordLimit => int.MaxValue;

        public int RecordCount
        {
            get => _recordCount;
            set => _recordCount = value;
        }

        public void LogInfo(string message)
        {
            _recordCount++;
        }
    }
}
