using System.Collections.Concurrent;

namespace _06.QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Quick Sort Algorithm -> Unstable, O(n log(n)), Space - O(n)

            int[] array = { 3, 5, 8, 9, 6, 2 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", array));

            Sort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", array));
        }

        public static void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                Sort(array, low, pi - 1);
                Sort(array, pi + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[low];
            int i = low + 1;
            int j = high;

            do
            {
                while (i <= j && array[i] <= pivot)
                {
                    i++;
                }
                while (i <= j && array[j] > pivot)
                {
                    j--;
                }

                if (i < j)
                {
                    Swap(array, i, j);
                }

            } while (i < j);

            Swap(array, low, j);

            return j;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}