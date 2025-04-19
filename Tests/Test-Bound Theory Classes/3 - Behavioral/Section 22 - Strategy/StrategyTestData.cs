using Exercises._3___Behavioral.Section_22___Strategy;
using System.Collections;
using System.Numerics;

namespace Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_22___Strategy
{
    public class StrategyTestData
    {
        public class PositiveTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    new OrdinaryDiscriminantStrategy(),
                    1.0, 10.0, 16.0,
                    new Complex(-2, 0),
                    new Complex(-8, 0)
                };

                yield return new object[]
                {
                    new OrdinaryDiscriminantStrategy(),
                    1.0, -5.0, 6.0,
                    new Complex(3, 0),
                    new Complex(2, 0)
                };

                yield return new object[]
                {
                    new OrdinaryDiscriminantStrategy(),
                    1.0, 6.0, 9.0,
                    new Complex(-3, 0),
                    new Complex(-3, 0)
                };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class NegativeOrdinaryTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    new OrdinaryDiscriminantStrategy(),
                    1.0, 4.0, 5.0,
                    new Complex(-2, 1),
                    new Complex(-2, -1)
                };

                yield return new object[]
                {
                    new OrdinaryDiscriminantStrategy(),
                    1.0, 2.0, 5.0,
                    new Complex(-1, 2),
                    new Complex(-1, -2)
                };

                yield return new object[]
                {
                    new OrdinaryDiscriminantStrategy(),
                    1.0, 1.0, 1.0,
                    new Complex(-0.5, Math.Sqrt(3) / 2),
                    new Complex(-0.5, -Math.Sqrt(3) / 2)
                };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class NegativeRealTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    new RealDiscriminantStrategy(),
                    1.0, 4.0, 5.0
                };

                yield return new object[]
                {
                    new RealDiscriminantStrategy(),
                    1.0, 2.0, 5.0
                };

                yield return new object[]
                {
                    new RealDiscriminantStrategy(),
                    1.0, 1.0, 1.0
                };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
