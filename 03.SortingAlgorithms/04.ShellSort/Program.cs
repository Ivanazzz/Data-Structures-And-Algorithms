namespace _04.ShellSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Shell Sort Algorithm -> Unstable, O(n log(n)), Space - O(1)

            int[] array = { 3, 5, 8, 9, 6, 2 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", array));

            Sort(array, array.Length);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", array));
        }

        public static void Sort(int[] array, int n)
        {
            int gap = n / 2;
            while (gap > 0)
            {
                int i = gap;
                while (i < n)
                {
                    int temp = array[i];
                    int j = i - gap;

                    while (j >= 0 && array[j] > temp)
                    {
                        array[j + gap] = array[j];
                        j -= gap;
                    }

                    array[j + gap] = temp;
                    i++;
                }

                gap /= 2;
            }
        }
    }
}