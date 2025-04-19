using Exercises._3___Behavioral.Section_23___Template;
using System.Collections;

namespace Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_23___Template
{
    public class TemplateTestData
    {
        public class ImpasseTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new Creature(1, 2), new Creature(1, 2), -1 };
                yield return new object[] { new Creature(1, 3), new Creature(1, 3), -1 };
                yield return new object[] { new Creature(2, 4), new Creature(1, 4), -1 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class TemporaryMurderTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new Creature(1, 1), new Creature(2, 2), 1 };
                yield return new object[] { new Creature(1, 1), new Creature(3, 3), 1 };
                yield return new object[] { new Creature(2, 1), new Creature(2, 2), -1 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class DoubleMurderTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new Creature(2, 2), new Creature(2, 2), -1 };
                yield return new object[] { new Creature(3, 3), new Creature(3, 3), -1 };
                yield return new object[] { new Creature(5, 5), new Creature(5, 5), -1 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class PermanentDamageTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new Creature(1, 2), new Creature(1, 3), -1, 1 };
                yield return new object[] { new Creature(1, 1), new Creature(2, 2), 1, 1 };
                yield return new object[] { new Creature(1, 5), new Creature(1, 2), -1, 0 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
