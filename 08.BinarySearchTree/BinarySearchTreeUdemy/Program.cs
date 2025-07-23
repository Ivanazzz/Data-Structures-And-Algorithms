namespace BinarySearchTreeUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.Root = tree.InsertRecursive(tree.Root, 50);
            tree.InsertIterative(30);
            tree.InsertIterative(80);
            tree.InsertIterative(10);
            tree.InsertIterative(40);
            tree.InsertIterative(60);
            tree.InsertIterative(90);

            Console.WriteLine($"Result from iterative search: {tree.SearchIterative(60)}"); // True
            Console.WriteLine($"Result from iterative search: {tree.SearchIterative(30)}"); // True
            Console.WriteLine($"Result from iterative search: {tree.SearchIterative(70)}"); // False

            Console.WriteLine($"Result from recursive search: {tree.SearchRecursive(tree.Root, 60)}"); // True
            Console.WriteLine($"Result from recursive search: {tree.SearchRecursive(tree.Root, 30)}"); // True
            Console.WriteLine($"Result from recursive search: {tree.SearchRecursive(tree.Root, 70)}"); // False

            //tree.InsertIterative(20);

            Console.Write("Inorder Traversal: "); 
            tree.TraverseInorder(tree.Root); // 10 30 40 50 60 80 90
            Console.WriteLine();

            Console.Write("Preorder Traversal: ");
            tree.TraversePreorder(tree.Root); // 50 30 10 40 80 60 90
            Console.WriteLine();

            Console.Write("Postorder Traversal: ");
            tree.TraversePostorder(tree.Root); // 10 40 30 60 90 80 50
            Console.WriteLine();

            Console.Write("Level Order Traversal: ");
            tree.TraverseLevelOrder(); // 50 30 80 10 40 60 90
            Console.WriteLine();

            Console.WriteLine($"Nodes count: {tree.Count(tree.Root)}"); // 7
            Console.WriteLine($"Height: {tree.Height(tree.Root)}"); // 3

            tree.Delete(50);

            Console.Write("Inorder Traversal: ");
            tree.TraverseInorder(tree.Root); // 10 30 40 60 80 90
            Console.WriteLine();

            Console.WriteLine($"Nodes count: {tree.Count(tree.Root)}"); // 6
            Console.WriteLine($"Height: {tree.Height(tree.Root)}");// 3
        }
    }
}
