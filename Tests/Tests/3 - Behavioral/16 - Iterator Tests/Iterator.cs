﻿using Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_16___Iterator;

namespace Tests.Tests._3___Behavioral._16___Iterator_Tests
{
    public class Iterator
    {
        [Theory]
        [ClassData(typeof(IteratorTestData))]
        public void AssertIterator(IteratorComplexFields field)
        {
            // Act
            string preOrderedBinaryTree = new string(field.Root.PreOrder.ToArray());

            // Assert
            Assert.Equal(field.ExpectedValue, preOrderedBinaryTree);
        }
    }
}
