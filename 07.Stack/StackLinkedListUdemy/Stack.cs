namespace StackLinkedListUdemy
{
    public class Stack
    {
        private Node top;
        private int size;

        public Stack()
        {
            top = null;
            size = 0;
        }

        public int Length => size;

        public void Push(int element)
        {
            Node newest = new Node(element, null);

            if (!IsEmpty)
            {
                newest.Next = top;
            }

            top = newest;
            size++;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is Empty/Underflow");
                return -1;
            }

            int element = top.Value;
            top = top.Next;
            size--;

            return element;
        }

        public int Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is Empty/Underflow");
                return -1;
            }

            return top.Value;
        }

        public void Print()
        {
            Node current = top;
            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        private bool IsEmpty => size == 0;
    }
}
