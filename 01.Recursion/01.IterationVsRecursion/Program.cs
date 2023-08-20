namespace _01.IterationVsRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateIterative(4); // OUTPUT: 16, 9, 4, 1
            CalculateRecursive(4); // OUTPUT: 16, 9, 4, 1
        }

        public static void CalculateIterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n--;
            }
        }

        public static void CalculateRecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateRecursive(n - 1);
            }
        }
    }
}