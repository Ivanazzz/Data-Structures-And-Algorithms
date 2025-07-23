namespace BinarySearchTreeUdemy
{
    public class Node
    {
        public int Element { get; set; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        public Node(int element, Node leftChild = null, Node rightChild = null)
        {
            Element = element;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }
}
