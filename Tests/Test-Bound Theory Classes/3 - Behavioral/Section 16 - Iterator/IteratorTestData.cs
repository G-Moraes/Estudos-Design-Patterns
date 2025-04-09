using Exercises._3___Behavioral.Section_16___Iterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Test_Bound_Theory_Classes._3___Behavioral.Section_16___Iterator
{
    public class IteratorComplexFields
    {
        public Node<char> Root;
        public string ExpectedValue;
    }

    public class IteratorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new IteratorComplexFields
                {
                    Root = new Node<char>('a',
                     new Node<char>('b',
            new Node<char>('c'), new Node<char>('d')),
                                         new Node<char>('e')),

                    ExpectedValue = "abcde"
                }
            };

            yield return new object[]
            {
                new IteratorComplexFields
                {
                    Root = new Node<char>('t',
                     new Node<char>('e',
                new Node<char>('s'), new Node<char>('t')), new Node<char>('e')),

                    ExpectedValue = "teste"
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
