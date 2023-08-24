namespace _05.MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Merge Sort Algorithm -> Stable, O(n log(n)), Space - O(n)

            int[] array = { 3, 5, 8, 9, 6, 2 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", array));

            Sort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", array));
        }

        public static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(array, left, mid);
                Sort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        private static void Merge(int[] array, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] resultArray = new int[right + 1];

            while (i <= mid && j <= right)
            {
                if (array[i] < array[j])
                {
                    resultArray[k] = array[i];
                    i++;
                } 
                else
                {
                    resultArray[k] = array[j];
                    j++;
                }

                k++;
            }

            while (i <= mid)
            {
                resultArray[k] = array[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                resultArray[k] = array[j];
                j++;
                k++;
            }

            for (int x = left; x <= right; x++)
            {
                array[x] = resultArray[x];
            }
        }
    }
}