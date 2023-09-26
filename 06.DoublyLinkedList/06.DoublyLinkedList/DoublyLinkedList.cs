namespace _06.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public Node<T>? First { get { return head; } }

        public Node<T>? Last { get { return tail; } }

        public int Count { get { return size; } }

        private bool IsEmpty => size == 0;

        public void AddFirst(Node<T> node)
        {
            if (IsEmpty)
            {
                tail = node;
            }
            else
            {
                node.Next = head;
                head.Previous = node;
            }

            head = node;
            size++;
        }

        public Node<T> AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);

            if (IsEmpty)
            {
                tail = node;
            }
            else
            {
                node.Next = head;
                head.Previous = node;
            }

            head = node;
            size++;

            return node;
        }

        public void AddLast(Node<T> node)
        {
            if (IsEmpty)
            {
                head = node;
            }
            else
            {
                node.Previous = tail;
                tail.Next = node;
            }

            tail = node;
            size++;
        }

        public Node<T> AddLast(T value)
        {
            Node<T> node = new Node<T>(value);

            if (IsEmpty)
            {
                head = node;
            }
            else
            {
                node.Previous = tail;
                tail.Next = node;
            }

            tail = node;
            size++;

            return node;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool Contains(T value)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public Node<T>? Find(int value)
        {
            Node<T> current = head;

            while (current != null )
            {
                if (current.Value.Equals(value))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public Node<T>? FindLast(int value)
        {
            Node<T> current = head;
            Node<T> result = null;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    result = current;
                }

                current = current.Next;
            }

            return result;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is empty!");
                return;
            }

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
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is empty!");
                return;
            }

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
        }

        public Node<T>? Merge(DoublyLinkedList<T> secondlist)
        {
            if (IsEmpty)
            {
                head = secondlist.head;
                tail = secondlist.tail;
                size += secondlist.size;
            }
            else if (!IsEmpty && !secondlist.IsEmpty)
            {
                tail.Next = secondlist.head;
                secondlist.head.Previous = tail;
                tail = secondlist.tail;
                size += secondlist.size;
            }

            return head;
        }

        public void Print()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public void PrintReversed()
        {
            Node<T> current = tail;

            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Previous;
            }

            Console.WriteLine();
        }

        public void ForEach(Action<Node<T>> action)
        {
            Node<T> node = head;

            while (node != null)
            {
                action(node);
                node = node.Next;
            }
        }
    }
}
