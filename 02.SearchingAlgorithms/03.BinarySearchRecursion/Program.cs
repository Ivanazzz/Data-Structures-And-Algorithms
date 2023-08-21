namespace _03.BinarySearchRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 11, 18, 30, 54 };
            int found = Search(array, 30, 0, array.Length - 1);
            Console.WriteLine(found); // OUTPUT: 3
        }

        public static int Search(int[] array, int key, int left, int right)
        {
            if (left > right)
            {
                return -1;
            } else
            {
                int middle = (left + right) / 2;
                if (array[middle] == key)
                {
                    return middle;
                }
                else if (array[middle] > key)
                {
                    return Search(array, key, left, middle - 1);
                }
                else if (array[middle] < key)
                {
                    return Search(array, key, middle + 1, right);
                }
            }

            return -1;
        }
    }
}