namespace Task6
{
    using System;
    using System.Collections.Generic;

    public class BSTree<T> : BTree<T>
        where T : IComparable
    {
        public BSTree() : base() { }

        public BSTree(T value, BSTree<T> leftTree, BSTree<T> rightTree) : base(value, leftTree, rightTree) { }

        public BSTree(T value, Node<T> leftNode, Node<T> rightNode)
        {
            this.Root = new Node<T>(value, leftNode, rightNode);
        }

        public List<string> TreeValues { get; private set; } = new List<string>(); 

        public override bool Equals(object obj)
        {
            BSTree<T> otherBSTree = (BSTree<T>)obj;

            if ((this.Root != null && otherBSTree.Root == null) || (this.Root == null && otherBSTree.Root != null))
            {
                return false;
            }
            else if (this.Root == null && otherBSTree.Root == null)
            {
                return true;
            }

            bool areLeftEqual = AreNodesEqual(this.Root.Left, otherBSTree.Root.Left);
            bool areRightEqual = AreNodesEqual(this.Root.Right, otherBSTree.Root.Right);

            return areLeftEqual && areRightEqual;
        }

        private bool AreNodesEqual(Node<T> firstNode, Node<T> secondNode)
        {
            if ((firstNode != null && secondNode == null) || (firstNode == null && secondNode != null))
            {
                return false;
            }
            else if (firstNode == null && secondNode == null)
            {
                return true;
            }

            if (firstNode.Value.Equals(secondNode.Value))
            {
                bool areLeftEqual = Equals(firstNode.Left, secondNode.Left);
                bool areRightEqual = Equals(firstNode.Right, secondNode.Right);

                return areLeftEqual && areRightEqual;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Root.Left.GetHashCode() ^ this.Root.GetHashCode() ^ this.Root.Right.GetHashCode();
        }

        public override string ToString()
        {
            return string.Join(" ", this.LoadTreeValues(this.Root));
        }

        private List<string> LoadTreeValues(Node<T> root)
        {
            if (root != null)
            {
                LoadTreeValues(root.Left);

                string result = (string)Convert.ChangeType(root.Value, typeof(string));
                TreeValues.Add(result);

                LoadTreeValues(root.Right);
            }

            return this.TreeValues;
        }

        public bool Find(T value)
        {
            return Find(this.Root, value);
        }

        public void Insert(T value)
        {
            Insert(this.Root, value);
        }

        public void DeleteNode(T value)
        {
            DeleteNode(this.Root, value);
        }

        private bool Find(Node<T> tree, T value)
        {
            if (tree == null)
            {
                return false;
            }
            else if (value.CompareTo(tree.Value) < 0)
            {
                return Find(tree.Left, value);
            }
            else if (value.CompareTo(tree.Value) > 0)
            {
                return Find(tree.Right, value);
            }
            else
            {
                return true;
            }
        }

        private void Insert(Node<T> tree, T value)
        {
            bool flagInserted = false;

            if (tree == null)
            {
                tree = new Node<T>(value);
            }
            else if (value.CompareTo(tree.Value) <= 0)
            {
                if (tree.Left == null)
                {
                    tree.Left = new Node<T>(value);
                    flagInserted = true;
                }

                if (flagInserted != true)
                {
                    Insert(tree.Left, value);
                }
            }
            else if (value.CompareTo(tree.Value) > 0)
            {
                if (tree.Right == null)
                {
                    tree.Right = new Node<T>(value);
                    flagInserted = true;
                }

                if (flagInserted != true)
                {
                    Insert(tree.Right, value);
                }
            }
        }

        private void DeleteNode(Node<T> tree, T value)
        {
            if (tree == null)
            {
                return;
            }

            if (value.CompareTo(tree.Value) < 0)
            {
                DeleteNode(tree.Left, value);
            }
            else if (value.CompareTo(tree.Value) > 0)
            {
                DeleteNode(tree.Right, value);
            }
            else
            {
                Node<T> tempNode;

                if (tree.Left == null)
                {
                    tempNode = tree.Right;
                    tree.Value = default(T);
                    tree = tempNode;
                }
                else if (tree.Right == null)
                {
                    tempNode = tree.Left;
                    tree.Value = default(T);
                    tree = tempNode;
                }
                else
                {
                    tempNode = tree.Right;

                    while (tempNode.Left != null)
                    {
                        tempNode = tempNode.Left;
                    }

                    tree.Value = tempNode.Value;

                    DeleteNode(tree.Right, tempNode.Value);
                }
            }
        }
    }
}
