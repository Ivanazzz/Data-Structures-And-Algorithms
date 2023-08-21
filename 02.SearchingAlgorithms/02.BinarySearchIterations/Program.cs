namespace _02.BinarySearchIterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 11, 18, 30, 54 };
            int found = Search(array, array.Length, 30);
            Console.WriteLine(found); // OUTPUT: 3
        }

        public static int Search(int[] array, int n, int key)
        {
            int left = 0;
            int right = n - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == key)
                {
                    return middle;
                }
                
                if (array[middle] > key)
                {
                    right = middle - 1;
                } else if (array[middle] < key)
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}