using System.Collections;

namespace Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_15____Interpreter
{
    public class InterpreterComplexFields
    {
        public string Expression;
        public Dictionary<char, int> Variables = new Dictionary<char, int>();
        public int ExpectedValue;
    }

    public class InterpreterTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "11",
                    ExpectedValue = 11
                }
            };

            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "x",
                    Variables   = new Dictionary<char, int>(){ { 'x', 5 } },
                    ExpectedValue = 5
                }
            };

            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "1+x",
                    Variables   = new Dictionary<char, int>(){ { 'x', 5 } },
                    ExpectedValue = 6
                }
            };

            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "1+x+3",
                    Variables   = new Dictionary<char, int>(){ { 'x', 2 } },
                    ExpectedValue = 6
                }
            };

            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "1+x+y",
                    Variables   = new Dictionary<char, int>(){ { 'x', 2 }, { 'y', 3 } },
                    ExpectedValue = 6
                }
            };

            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "1+2+3",
                    ExpectedValue = 6
                }
            };

            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "1+2+3+4",
                    ExpectedValue = 10
                }
            };

            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "476+22+5+43",
                    ExpectedValue = 546
                }
            };

            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "x+y+5+z",
                    Variables   = new Dictionary<char, int>(){ { 'x', 476 }, { 'y', 22 } },
                    ExpectedValue = 0
                }
            };

            yield return new object[]
            {
                new InterpreterComplexFields
                {
                    Expression  = "1+2+3+xy",
                    Variables   = new Dictionary<char, int>(){ { 'x', 5 } },
                    ExpectedValue = 0
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
