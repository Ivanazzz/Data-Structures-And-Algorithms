namespace _01.LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 84, 21, 47, 96, 15 };
            int found = Search(array, array.Length, 96);
            Console.WriteLine(found); // OUTPUT: 3
        }

        public static int Search(int[] array, int n, int key)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] == key)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}