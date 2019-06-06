namespace Task6
{
    using System;

    public class Node<T>
        where T : IComparable
    {
        public Node() { }

        public Node(T value, Node<T> left = null, Node<T> right = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }

        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
    }
}
