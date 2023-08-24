using System.Globalization;

namespace _01.SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Selection Sort Algorithm -> Unstable, O(n^2), Space - O(1)

            int[] array = { 3, 5, 8, 9, 6, 2 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", array));

            Sort(array, array.Length);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", array));
        }

        public static void Sort(int[] array, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[position])
                    {
                        position = j;
                    }
                }

                int temp = array[i];
                array[i] = array[position];
                array[position] = temp;
            }
        }
    }
}