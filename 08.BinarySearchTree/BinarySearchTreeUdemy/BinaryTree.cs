namespace BinarySearchTreeUdemy
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node root = null)
        {
            Root = root;   
        }

        public bool SearchIterative(int key)
        {
            Node root = Root;

            while (root != null)
            {
                if (key == root.Element)
                {
                    return true;
                }
                else if (key < root.Element)
                {
                    root = root.LeftChild;
                }
                else if (key > root.Element)
                {
                    root = root.RightChild;
                }
            }

            return false;
        }

        public bool SearchRecursive(Node tempRoot, int key)
        {
            if (tempRoot != null)
            {
                if (key == tempRoot.Element)
                {
                    return true;
                }
                else if (key < tempRoot.Element)
                {
                    return SearchRecursive(tempRoot.LeftChild, key);
                }
                else if (key > tempRoot.Element)
                {
                    return SearchRecursive(tempRoot.RightChild, key);
                }
            }

            return false;
        }

        public void InsertIterative(int value)
        {
            Node temp = null;
            Node tempRoot = Root;

            while (tempRoot != null)
            {
                temp = tempRoot;

                if (value == tempRoot.Element)
                {
                    Console.WriteLine("Element already exists!");
                    return;
                }
                else if (value < tempRoot.Element)
                {
                    tempRoot = tempRoot.LeftChild;
                }
                else if (value > tempRoot.Element)
                {
                    tempRoot = tempRoot.RightChild;
                }
            }

            Node node = new Node(value);

            if (Root != null)
            {
                if (value < temp.Element)
                {
                    temp.LeftChild = node;
                }
                else
                {
                    temp.RightChild = node;
                }
            }
            else
            {
                Root = node;
            }
        }

        public Node InsertRecursive(Node tempRoot, int value)
        {
            if (tempRoot != null)
            {
                if (value < tempRoot.Element)
                {
                    InsertRecursive(tempRoot.LeftChild, value);
                }
                else if (value > tempRoot.Element)
                {
                    InsertRecursive(tempRoot.RightChild, value);
                }
            }
            else
            {
                Node node = new Node(value);
                tempRoot = node;
            }

            return tempRoot;
        }

        public bool Delete(int value)
        {
            Node node = Root;
            Node parentOfTheNode = null;

            while (node != null && node.Element != value)
            {
                parentOfTheNode = node;

                if (value < node.Element)
                {
                    node = node.LeftChild;
                }
                else
                {
                    node = node.RightChild;
                }
            }

            if (node == null)
            {
                return false;
            }

            if (node.LeftChild != null && node.RightChild != null)
            {
                Node smallest = node.LeftChild;
                Node parentOfTheSmallest = node;

                while (smallest.RightChild != null)
                {
                    parentOfTheSmallest = smallest;
                    smallest = smallest.RightChild;
                }

                node.Element = smallest.Element;
                node = smallest;
                parentOfTheNode = parentOfTheSmallest;
            }

            Node current = null;

            if (node.LeftChild != null)
            {
                current = node.LeftChild;
            }
            else
            {
                current = node.RightChild;
            }

            if (node == Root)
            {
                Root = null;
            }
            else
            {
                if (node == parentOfTheNode.LeftChild)
                {
                    parentOfTheNode.LeftChild = current;
                }
                else
                {
                    parentOfTheNode.RightChild = current;
                }
            }

            return true;
        }

        public void TraverseInorder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                TraverseInorder(tempRoot.LeftChild);

                Console.Write($"{tempRoot.Element} ");

                TraverseInorder(tempRoot.RightChild);
            }
        }

        public void TraversePreorder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                Console.Write($"{tempRoot.Element} ");

                TraversePreorder(tempRoot.LeftChild);

                TraversePreorder(tempRoot.RightChild);
            }
        }

        public void TraversePostorder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                TraversePostorder(tempRoot.LeftChild);

                TraversePostorder(tempRoot.RightChild);

                Console.Write($"{tempRoot.Element} ");
            }
        }

        public void TraverseLevelOrder()
        {
            Queue<Node> queue = new Queue<Node>();
            Node tempRoot = Root;

            Console.Write($"{tempRoot.Element} ");
            queue.Enqueue(tempRoot);

            while (queue.Count > 0)
            {
                tempRoot = queue.Dequeue();

                if (tempRoot.LeftChild != null)
                {
                    Console.Write($"{tempRoot.LeftChild.Element} ");
                    queue.Enqueue(tempRoot.LeftChild);
                }

                if (tempRoot.RightChild != null)
                {
                    Console.Write($"{tempRoot.RightChild.Element} ");
                    queue.Enqueue(tempRoot.RightChild);
                }
            }
        }

        public int Count(Node tempRoot)
        {
            if (tempRoot != null)
            {
                int leftNodesCount = Count(tempRoot.LeftChild);
                int rightNodesCount = Count(tempRoot.RightChild);

                return leftNodesCount + rightNodesCount + 1;
            }

            return 0;
        }

        public int Height(Node tempRoot)
        {
            if (tempRoot != null)
            {
                int leftHeight = Height(tempRoot.LeftChild);
                int rightHeight = Height(tempRoot.RightChild);

                if (leftHeight > rightHeight)
                {
                    return leftHeight + 1;
                }
                else
                {
                    return rightHeight + 1;
                }
            }

            return 0;
        }
    }
}
