namespace _03.TreeRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeRecursion(3); // OUTPUT: 1, 4, 1, 9, 1, 4, 1
        }

        public static void TreeRecursion(int n)
        {
            if (n > 0)
            {
                TreeRecursion(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                TreeRecursion(n - 1);
            }
        }
    }
}