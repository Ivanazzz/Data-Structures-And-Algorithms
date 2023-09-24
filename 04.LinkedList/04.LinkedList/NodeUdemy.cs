namespace _04.LinkedList
{
    public class NodeUdemy
    {
        public NodeUdemy(int value, NodeUdemy next)
        {
            Value = value;
            Next = next;
        }

        public int Value { get; set; }

        public NodeUdemy Next { get; set; }
    }
}
