namespace _04.LinkedList
{
    public class LinkedList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Count { get { return size; } }

        public Node<T>? First { get { return head; } }

        public Node<T>? Last { get { return tail; } }

        public void AddFirst(Node<T> node)
        {
            if (isEmpty)
            {
                tail = node;
            }
            else
            {
                node.Next = head;
            }

            head = node;
            size++;
        }

        public Node<T> AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);

            if (isEmpty)
            {
                tail = node;
            }
            else
            {
                node.Next = head;
            }

            head = node;
            size++;

            return node;
        }

        public void AddLast(Node<T> node)
        {
            if (isEmpty)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }

            tail = node;
            size++;
        }

        public Node<T> AddLast(T value)
        {
            Node<T> node = new Node<T>(value);

            if (isEmpty)
            {
                head = node;
            }
            else
            {
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

        public Node<T>? Find(T value)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public Node<T>? FindLast(T value)
        {
            Node<T> current = head;
            Node<T>? nodeToReturn = null;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    nodeToReturn = current;
                }

                current = current.Next;
            }

            return nodeToReturn;
        }

        public void RemoveFirst()
        {
            if (isEmpty)
            {
                Console.WriteLine("List is empty!");    
                return;
            }

            head = head.Next;
            size--;

            if (isEmpty)
            {
                tail = null;
            }
        }

        public void RemoveLast()
        {
            if (isEmpty)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Node<T> current = head;
            int position = 1;

            while (position < size - 1)
            {
                current = current.Next;
                position++;
            }

            current.Next = null;
            tail = current;
            size--;

            if (isEmpty)
            {
                head = null;
                tail = null;
            }
        }

        public Node<T>? Merge(LinkedList<T> secondLinkedList)
        {
            if (isEmpty)
            {
                head = secondLinkedList.head;
                tail = secondLinkedList.tail;
                size += secondLinkedList.size;
            }
            else if (!isEmpty && !secondLinkedList.isEmpty)
            {
                tail.Next = secondLinkedList.head;
                tail = secondLinkedList.tail;
                size += secondLinkedList.size;
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

        public void ForEach(Action<Node<T>> action)
        {
            Node<T> node = head;

            while (node != null)
            {
                action(node);
                node = node.Next;
            }
        }

        private bool isEmpty => size == 0;
    }
}
