using System.Collections;

namespace Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_21___State
{
    public class StateTestData
    {
        public class CombinationLockTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }, "OPEN" };
                yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 6 }, "ERROR" };
                yield return new object[] { new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2, 1 }, "OPEN" };
                yield return new object[] { new int[] { 9, 8, 7, 6, 5 }, new int[] { 9, 8, 7, 6, 4 }, "ERROR" };
                yield return new object[] { new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 }, "OPEN" };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
