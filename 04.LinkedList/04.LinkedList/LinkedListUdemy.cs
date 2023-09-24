namespace _04.LinkedList
{
    public class LinkedListUdemy
    {
        private NodeUdemy head;
        private NodeUdemy tail;
        private int size;

        public LinkedListUdemy()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length { get { return size; } }

        public bool isEmpty { get { return size == 0; } }

        public void AddLast(int value)
        {
            NodeUdemy newest = new NodeUdemy(value, null);

            if (this.isEmpty)
            {
                head = newest;
            }
            else
            {
                tail.Next = newest;
            }

            tail = newest;
            size++;
        }

        public void AddFirst(int value)
        {
            NodeUdemy newest = new NodeUdemy(value, null);

            if (this.isEmpty)
            {
                tail = newest;
            }
            else
            {
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

            NodeUdemy newest = new NodeUdemy(value, null);
            NodeUdemy current = head;
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
            if (this.isEmpty)
            {
                Console.WriteLine("List is empty!");
                return -1;
            }

            int removedValue = head.Value;
            head = head.Next;
            size--;

            if (this.isEmpty)
            {
                tail = null;
            }

            return removedValue;
        }

        public int RemoveLast()
        {
            if (this.isEmpty)
            {
                Console.WriteLine("List is empty!");
                return -1;
            }
            else if (size == 1)
            {
                int value = tail.Value;
                head = null;
                tail = null;
                size--;

                return value;
            }

            NodeUdemy current = head;
            int i = 1;

            while (i < size - 1)
            {
                current = current.Next;
                i++;
            }

            tail = current;
            current = current.Next;
            int removedValue = current.Value;
            tail.Next = null;
            size--;

            return removedValue;
        }

        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid position!");
                return -1;
            }

            NodeUdemy current = head;
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

        public int Search(int key)
        {
            NodeUdemy current = head;
            int index = 0;

            while (current != null)
            {
                if (current.Value == key)
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;
        }

        public void InsertSorted(int value)
        {
            NodeUdemy newest = new NodeUdemy(value, null);

            if (this.isEmpty)
            {
                head = newest;
            }
            else
            {
                NodeUdemy current = head;
                NodeUdemy node = head;

                while (current != null && current.Value < value)
                {
                    node = current;
                    current = current.Next;
                }

                if (current == head)
                {
                    newest.Next = head;
                    head = newest;
                }
                else
                {
                    newest.Next = node.Next;
                    node.Next = newest;
                }
            }

            size++;
        }

        public void Print()
        {
            NodeUdemy current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}
