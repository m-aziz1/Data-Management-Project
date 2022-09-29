namespace Algorithms
{
    public static class Search
    {
        // Linear Search
        public static int linearSearch(int[] anArray, int item)
        {
            for (int i = 0; i < anArray.Length; i++)
            {
                if (anArray[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int linearSearch(string[] anArray, string item)
        {
            for (int i = 0; i < anArray.Length; i++)
            {
                if (anArray[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        // Binary Search
        public static int binarySearch(int[] anArray, int item)
        {
            int beg = 0;
            int end = anArray.Length - 1;
            int mid;

            while (beg <= end)
            {
                mid = (beg + end) / 2;
                if (item == anArray[mid])
                {
                    return mid;
                }
                else if (item < anArray[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    beg = mid + 1;
                }
            }
            return -1;
        }

        public static int binarySearch(string[] anArray, string item)
        {
            int beg = 0;
            int end = anArray.Length - 1;
            int mid;

            while (beg <= end)
            {
                mid = (beg + end) / 2;
                int exists = item.CompareTo(anArray[mid]);
                if (exists == 0)
                {
                    return mid;
                }
                else if (exists < 0)
                {
                    end = mid - 1;
                }
                else
                {
                    beg = mid + 1;
                }
            }
            return -1;
        }
    }
}
