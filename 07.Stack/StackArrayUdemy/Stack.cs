namespace StackArrayUdemy
{
    public class Stack
    {
        int[] data;
        int top;

        public Stack(int n)
        {
            data = new int[n];
            top = 0;
        }

        public int Length => top;

        public void Push(int element)
        {
            if (IsFull)
            {
                Console.WriteLine("Stack is Full/Overflow");
                return;
            }

            data[top] = element;
            top++;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is Empty/Underflow");
                return -1;
            }

            int element = data[top - 1];
            top--;

            return element;
        }

        public int Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is Empty/Underflow");
                return -1;
            }

            return data[top - 1];
        }

        public void Print()
        {
            for (int i = 0; i < top; i++)
            {
                Console.Write($"{data[i]} ");
            }

            Console.WriteLine();
        }

        private bool IsEmpty => top == 0;

        private bool IsFull => top == data.Length;
    }
}
