using Exercises._3___Behavioral.Section_19___Null_Object;

namespace Tests.Tests._3___Behavioral._19___Null_Object_Tests
{
    public class NullObject
    {
        [Fact]
        public void AssertNullObjectSingleLogCall()
        {
            // Arrange
            Account accountWithIlog     = new Account(null);
            Account accountWithNullLog  = new Account(new NullLog());

            // Assert
            Assert.ThrowsAny<Exception>(accountWithIlog.SomeOperation);
        }

        [Fact]
        public void AssertNullObjectManyLogCall()
        {
            // Arrange
            Account accountWithIlog     = new Account(null);
            Account accountWithNullLog  = new Account(new NullLog());

            // Assert
            for(int i = 0; i < 100; i++)
            {
                Assert.ThrowsAny<Exception>(accountWithIlog.SomeOperation);
            }
        }
    }
}
