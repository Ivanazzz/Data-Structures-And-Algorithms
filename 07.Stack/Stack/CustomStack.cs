namespace Stack
{
    public class CustomStack<T>
    {
        private const int DefaultSize = 2;
        private T[] array;
        private int index;

        public CustomStack()
        {
            array = new T[DefaultSize];
            index = 0;
        }

        public int Count { get { return index; } }

        public void Push(T item)
        {
            if (!IsThereEnoughSpace)
            {
                array = ExpandArray();
            }

            array[index] = item;
            index++;
        }

        public T? Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }

            T element = array[index - 1];
            array[index - 1] = default(T);
            index--;

            if (CanArrayShrink)
            {
                array = ShrinkArray();
            }

            return element;
        }

        public T? Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }

            return array[index - 1];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            array = new T[DefaultSize];
            index = 0;
        }

        private bool IsEmpty => Count == 0;

        private bool IsThereEnoughSpace => Count < array.Length;

        private bool CanArrayShrink => Count <= array.Length / DefaultSize;

        private T[] ExpandArray()
        {
            int newSize = array.Length * DefaultSize;
            T[] tempArray = new T[newSize];

            for (int i = 0; i < Count; i++)
            {
                tempArray[i] = array[i];
            }

            return tempArray;
        }

        private T[] ShrinkArray()
        {
            int newSize = array.Length / DefaultSize;
            T[] tempArray = new T[newSize];

            for (int i = 0; i < newSize; i++)
            {
                tempArray[i] = array[i];
            }

            return tempArray;
        }
    }
}
