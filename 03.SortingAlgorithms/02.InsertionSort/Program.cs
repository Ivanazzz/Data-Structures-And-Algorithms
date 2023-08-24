namespace _02.InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Insertion Sort Algorithm -> Stable, O(n^2), Space - O(1)

            int[] array = { 3, 5, 8, 9, 6, 2 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", array));

            Sort(array, array.Length);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", array));
        }

        public static void Sort(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = array[i];
                int position = i;
                
                while (position > 0 && array[position - 1] > temp)
                {
                    array[position] = array[position - 1];
                    position--;
                }

                array[position] = temp;
            }
        }
    }
}