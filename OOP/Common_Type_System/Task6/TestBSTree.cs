namespace Task6
{
    using System;

    class TestBSTree
    {
        static void Main()
        {
            Node<int> leftNodeFirstTree = new Node<int>(9);
            Node<int> rightNodeFirstTree = new Node<int>(11);
            BSTree<int> firstTree = new BSTree<int>(10, leftNodeFirstTree, rightNodeFirstTree);

            Node<int> leftNodeSecondTree = new Node<int>(9);
            Node<int> rightNodeSecondTree = new Node<int>(11);
            BSTree<int> secondTree = new BSTree<int>(10, leftNodeSecondTree, rightNodeSecondTree);

            Console.WriteLine("Shows if tree is empty: " + firstTree.IsEmpty());
            Console.WriteLine("Shows if the node is leaf: " + firstTree.IsLeaf(leftNodeFirstTree));
            Console.WriteLine("Checks if the tree contains specific T value: " + firstTree.Find(9));
            Console.WriteLine("Return hashCode based on the root and the first two inheritors: " + firstTree.GetHashCode());
            Console.WriteLine("Inorder print");
            firstTree.Inorder();
            Console.WriteLine("Preorder print");
            firstTree.Preorder();
            Console.WriteLine("Postorder print");
            firstTree.Postorder();
            Console.WriteLine("Tree height: " + firstTree.Height());

            Console.WriteLine("\nAre trees equal:");
            Console.WriteLine(firstTree.Equals(secondTree));
            Console.WriteLine(firstTree != secondTree);

            Console.WriteLine("\nInsert: ");
            firstTree.Insert(13);
            firstTree.Insert(12);

            Console.WriteLine("\nPrint trees: ");
            Console.WriteLine(firstTree.ToString());

            Console.WriteLine("\nDelete: ");
            firstTree.DeleteNode(11);
            firstTree.DeleteNode(10);

            Console.WriteLine("\nPrint trees: ");
            Console.WriteLine(firstTree.ToString());
        }
    }
}
