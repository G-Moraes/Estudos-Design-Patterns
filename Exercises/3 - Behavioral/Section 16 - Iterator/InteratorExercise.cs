﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._3___Behavioral.Section_16___Iterator
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Left, Right;
        public Node<T> Parent;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;

            left.Parent = right.Parent = this;
        }

        IEnumerable<Node<T>> Traverse(Node<T> current)
        {
            yield return current;

            if (current.Left != null)
            {
                foreach (Node<T> left in Traverse(current.Left))
                {
                    yield return left;
                }
            }

            if (current.Right != null)
            {
                foreach (Node<T> right in Traverse(current.Right))
                {
                    yield return right;
                }
            }
        }

        public IEnumerable<T> PreOrder
        {
            get
            {
                foreach(Node<T> node in Traverse(this))
                {
                    yield return node.Value;
                }
            }
        }
    }
}
