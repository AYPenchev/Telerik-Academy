namespace Task6
{
    public class Node<T>
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
