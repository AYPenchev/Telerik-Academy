namespace Task6
{
    using System;

    public class BSTree<T> : BTree<T>
        where T : IComparable
    {
        public BSTree() : base() {}

        public BSTree(T value, BSTree<T> leftTree, BSTree<T> rightTree) : base(value, leftTree, rightTree) {}

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
            else if(value.CompareTo(tree.Value) > 0)
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
            if (tree == null)
            {
                tree = new Node<T>(value);
            }
            else if(value.CompareTo(tree.Value) <= 0)
            {
                Insert(tree.Left, value);
            }
            else
            {
                Insert(tree.Right, value);
            }
        }

        private void DeleteNode(Node<T> tree, T value)
        {
            if (tree == null)
            {
                return;
            }
            else if (value.CompareTo(tree.Value) < 0)
            {
                DeleteNode(tree.Left, value);
            }
            else if(value.CompareTo(tree.Value) > 0)
            {
                DeleteNode(tree.Right, value);
            }
            else
            {
                Node<T> tempNode;

                if (tree.Left == null)
                {
                    tempNode = tree.Right;
                    tree = tempNode;
                }
                else if (tree.Right == null)
                {
                    tempNode = tree.Left;
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
