namespace _06.DoublyLinkedList
{
    public class NodeUdemy
    {
        public NodeUdemy(int value, NodeUdemy next, NodeUdemy previous)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }

        public int Value { get; set; }

        public NodeUdemy Next { get; set; }

        public NodeUdemy Previous { get; set; }
    }
}
