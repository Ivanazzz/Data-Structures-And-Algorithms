namespace _05.Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialIteration(4)); // OUTPUT: 24
            Console.WriteLine(FactorialRecursion(4)); // OUTPUT: 24
        }

        public static int FactorialIteration(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        public static int FactorialRecursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return FactorialRecursion(n - 1) * n;
        }
    }
}