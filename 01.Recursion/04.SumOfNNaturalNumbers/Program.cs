namespace _04.SumOfNNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5)); // OUTPUT: 15
            Console.WriteLine(SumIteration(5)); // OUTPUT: 15
            Console.WriteLine(SumRecursion(5)); // OUTPUT: 15
        }

        public static int Sum(int n)
        {
            return n * (n + 1) / 2;
        }

        public static int SumIteration(int n)
        {
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                total += i;
                i++;
            }

            return total;   
        }

        public static int SumRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return Sum(n - 1) + n;
        }
    }
}