namespace StackArrayUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(4);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.Print();
            Console.WriteLine($"Size: {stack.Length}");
            Console.WriteLine(stack.Peek());

            stack.Pop();
            stack.Pop();

            stack.Print();
            Console.WriteLine($"Size: {stack.Length}");
            Console.WriteLine(stack.Peek());

            stack.Pop();
            stack.Pop();
            stack.Pop();
        }
    }
}