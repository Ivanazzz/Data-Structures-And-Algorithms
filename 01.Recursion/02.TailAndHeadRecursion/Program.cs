namespace _02.TailAndHeadRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeadRecursion(4); // OUTPUT: 1, 4, 9, 16
            TailRecursion(4); // OUTPUT: 16, 9, 4, 1
        }

        public static void HeadRecursion(int n)
        {
            if (n > 0)
            {
                HeadRecursion(n - 1);
                int k = n * n;
                Console.WriteLine(k);
            }
        }

        public static void TailRecursion(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                TailRecursion(n - 1);
            }
        }
    }
}