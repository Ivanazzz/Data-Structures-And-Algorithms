namespace _03.BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bubble Sort Algorithm -> Stable, O(n^2), Space - O(1)

            int[] array = { 3, 5, 8, 9, 6, 2 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", array));

            Sort(array, array.Length);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", array));
        }

        public static void Sort(int[] array, int n)
        {
            for (int pass = n - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
    }
}