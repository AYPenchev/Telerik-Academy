namespace Task6
{
    using System;

    public class BTree<T>
    {
        public BTree()
        {
            this.Root = null;
        }

        public BTree(BTree<T> source)
        {
            if (source.Root == null)
            {
                this.Root = null;
            }
            else
            {
                this.CopyTree(this.Root, source.Root);
            }
        }

        public BTree(T value, BTree<T> leftTree, BTree<T> rightTree)
        {
            this.Root = new Node<T>(value, leftTree.Root, rightTree.Root);
        }

        private BTree(Node<T> newTree)
        {
            this.Root = newTree;
        }

        protected Node<T> Root { get; set; }

        public override bool Equals(object obj)
        {
            var otherTree = (BTree<T>)obj;
            return this.Root == otherTree.Root;
        }

        public static bool operator ==(BTree<T> firstTree, BTree<T> secondTree)
        {
            return BTree<T>.Equals(firstTree, secondTree);
        }

        public static bool operator !=(BTree<T> firstTree, BTree<T> secondTree)
        {
            return !BTree<T>.Equals(firstTree, secondTree);
        }

        public T RootValue
        {
            get
            {
                return this.Root.Value;
            }
        }

        public BTree<T> LeftValue
        {
            get
            {
                if (this.Root != null)
                {
                    return new BTree<T>(this.Root.Left);
                }
                else
                {
                    Console.WriteLine("The tree is empty.");
                    return null;
                }
            }
        }

        public BTree<T> RightValue
        {
            get
            {
                if (this.Root != null)
                {
                    return new BTree<T>(this.Root.Right);
                }
                else
                {
                    Console.WriteLine("The tree is empty.");
                    return null;
                }
            }
        }

        public void Inorder()
        {
            this.Inorder(this.Root);
        }

        public void Preorder()
        {
            this.Preorder(this.Root);
        }

        public void Postorder()
        {
            this.Postorder(this.Root);
        }
   
        public bool IsEmpty()
        {
            return this.Root == null;
        }

        public bool IsLeaf()
        {
            bool isLeaf = false;

            if (this.Root != null)
            {
                isLeaf = (this.Root.Left == null) && (this.Root.Right == null);
            }

            return isLeaf;
        }

        public int Height()
        {
            return this.Height(this.Root);
        }

        private void CopyTree(Node<T> newTree, Node<T> original)
        {
            if (original == null)
            {
                newTree = null;
            }
            else
            {
                newTree = new Node<T>();
                newTree.Value = original.Value;
                CopyTree(newTree.Left, original.Left);
                CopyTree(newTree.Right, original.Right);
            }
        }

        private int Height(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(Height(tree.Left), Height(tree.Right));
            }
        }

        private void Inorder(Node<T> root)
        {
            if (root != null)
            {
                Inorder(root.Left);
                Process(root);
                Inorder(root.Right);
            }
        }

        private void Preorder(Node<T> root)
        {
            if (root != null)
            {
                Process(root);
                Preorder(root.Left);
                Preorder(root.Right);
            }
        }

        private void Postorder(Node<T> root)
        {
            if (root != null)
            {
                Postorder(root.Left);
                Postorder(root.Right);
                Process(root);
            }
        }

        private void Process(Node<T> root)
        {
            Console.WriteLine(root.Value + " ");
        }

    }
}
