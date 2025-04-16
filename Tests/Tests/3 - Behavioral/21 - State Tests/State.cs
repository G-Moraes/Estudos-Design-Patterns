using Exercises._3___Behavioral.Section_21___State;
using static Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_21___State.StateTestData;

namespace Tests.Tests._3___Behavioral._21___State_Tests
{
    public class State
    {
        [Theory]
        [ClassData(typeof(CombinationLockTestData))]
        public void AssertState(int[] lockCombination, int[] toBeAddedDigits, string expectedOutput)
        {
            // Arrange
            CombinationLock cl = new CombinationLock(lockCombination);

            // Act
            foreach(int digit in toBeAddedDigits)
            {
                cl.EnterDigit(digit);
            }

            // Assert
            Assert.Equal(expectedOutput, cl.Status);
        
        }
    }
}
