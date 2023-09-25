namespace _05.CircularLinkedList
{
    public class CircularLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length { get { return size; } }

        public void AddLast(int value)
        {
            Node newest = new Node(value, null);

            if (isEmpty)
            {
                newest.Next = newest;
                head = newest;
            }
            else
            {
                newest.Next = tail.Next;
                tail.Next = newest;
            }

            tail = newest;
            size++;
        }

        public void AddFirst(int value)
        {
            Node newest = new Node(value, null);

            if (isEmpty)
            {
                newest.Next = newest;
                tail = newest;
            }
            else
            {
                tail.Next = newest;
                newest.Next = head;
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

            Node newest = new Node(value, null);
            Node current = head;
            int i = 1;

            while (i < position - 1)
            {
                current = current.Next;
                i++;
            }

            newest.Next = current.Next;
            current.Next = newest;
            size++;
        }

        public int RemoveFirst()
        {
            if (isEmpty)
            {
                Console.WriteLine("Circular list is empty!");
                return -1;
            }

            int removedValue = head.Value;
            tail.Next = head.Next;
            head = head.Next;
            size--;

            if (isEmpty)
            {
                head = null;
                tail = null;
            }

            return removedValue;
        }

        public int RemoveLast()
        {
            if (isEmpty)
            {
                Console.WriteLine("Circular list is empty!");
                return -1;
            }

            Node current = head;
            int i = 0;

            while (i < Length - 1)
            {
                current = current.Next;
                i++;
            }
            
            tail = current;
            current = current.Next;
            tail.Next = head;
            int removedValue = current.Value;
            size--;

            if (isEmpty)
            {
                head = null;
                tail = null;
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
            else if (isEmpty)
            {
                Console.WriteLine("Circular list is empty!");
                return -1;
            }

            Node current = head;
            int i = 1;

            while (i < position - 1)
            {
                current = current.Next;
                i++;
            }

            int removedValue = current.Next.Value;
            current.Next = current.Next.Next;
            size--;

            return removedValue;
        }

        public void Print()
        {
            Node current = head;
            int i = 0;

            while (i < Length)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
                i++;
            }

            Console.WriteLine();
        }

        private bool isEmpty => size == 0;
    }
}
