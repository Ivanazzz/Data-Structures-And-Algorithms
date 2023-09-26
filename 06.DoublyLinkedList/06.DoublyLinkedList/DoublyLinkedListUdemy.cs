namespace _06.DoublyLinkedList
{
    public class DoublyLinkedListUdemy
    {
        private NodeUdemy head;
        private NodeUdemy tail;
        private int size;

        public DoublyLinkedListUdemy()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length { get { return size; } }

        public void AddLast(int value)
        {
            NodeUdemy newest = new NodeUdemy(value, null, null);

            if (IsEmpty)
            {
                head = newest;
            }
            else
            {
                tail.Next = newest;
                newest.Previous = tail;
            }

            tail = newest;
            size++;
        }

        public void AddFirst(int value)
        {
            NodeUdemy newest = new NodeUdemy(value, null, null);

            if (IsEmpty)
            {
                tail = newest;
            }
            else
            {
                newest.Next = head;
                head.Previous = newest;
            }

            head = newest;
            size++;
        }

        public void AddAny(int value, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid position!");
                return;
            }

            NodeUdemy newest = new NodeUdemy(value, null, null);
            NodeUdemy current = head;
            int i = 1;

            while (i < position - 1)
            {
                current = current.Next;
                i++;
            }

            newest.Next = current.Next;
            newest.Next.Previous = newest;
            current.Next = newest;
            newest.Previous = current;
            size++;
        }

        public int RemoveFirst()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Doubly Linked List is empty!");
                return -1;
            }

            int removedValue = head.Value;
            head = head.Next;
            size--;

            if (IsEmpty)
            {
                tail = null;
            }
            else
            {
                head.Previous = null;
            }

            return removedValue;
        }

        public int RemoveLast()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Doubly Linked List is empty!");
                return -1;
            }

            int removedValue = tail.Value;
            tail = tail.Previous;
            size--;

            if (IsEmpty)
            {
                head = null;
            }
            else
            {
                tail.Next = null;
            }

            return removedValue;
        }

        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid position!");
                return -1;
            }

            NodeUdemy current = head;
            int i = 1;

            while(i < position)
            {
                current = current.Next;
                i++;
            }

            int removedValue = current.Next.Value;
            current.Next = current.Next.Next;
            current.Next.Previous = current;
            size--;

            return removedValue;
        }

        public void Print()
        {
            NodeUdemy current = head;

            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }

            Console.WriteLine();
        }
        public void PrintReversed()
        {
            NodeUdemy current = tail;

            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Previous;
            }

            Console.WriteLine();
        }


        private bool IsEmpty => size == 0;
    }
}
