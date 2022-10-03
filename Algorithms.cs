namespace Algorithms
{
    public static class Search
    {
        // Linear Search
        public static int linear(int[] anArray, int item)
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

        public static int linear(string[] anArray, string item)
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
        public static int binary(int[] anArray, int item)
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

        public static int binary(string[] anArray, string item)
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

    public static class Sort
    {
        // Bubble Sort
        public static void bubble(int[] anArray)
        {
            for (int i = anArray.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (anArray[j] > anArray[j + 1])
                    {
                        int temp = anArray[j];
                        anArray[j] = anArray[j + 1];
                        anArray[j + 1] = temp;
                    }
                }
            }
        }

        public static void bubble(string[] anArray)
        {
            for (int i = anArray.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    int cmpVal = anArray[j].CompareTo(anArray[j + 1]);
                    if (cmpVal > 0)
                    {
                        string temp = anArray[j];
                        anArray[j] = anArray[j + 1];
                        anArray[j + 1] = temp;
                    }
                }
            }
        }

        // Selection Sort
        public static void selection(int[] anArray)
        {
            int minPos;
            int arrLength = anArray.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                minPos = i;
                for (int j = i + 1; j < arrLength; j++)
                {
                    if (anArray[j] < anArray[minPos])
                    {
                        minPos = j;
                    }
                }
                int temp = anArray[i];
                anArray[i] = anArray[minPos];
                anArray[minPos] = temp;
            }
        }

        public static void selection(string[] anArray)
        {
            int minPos;
            int arrLength = anArray.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                minPos = i;
                for (int j = i + 1; j < arrLength; j++)
                {
                    int cmpVal = anArray[j].CompareTo(anArray[minPos]);
                    if (cmpVal < 0)
                    {
                        minPos = j;
                    }
                }
                string temp = anArray[i];
                anArray[i] = anArray[minPos];
                anArray[minPos] = temp;
            }
        }

        // Insertion Sort
        public static void insertion(int[] anArray)
        {
            int insertPos,
                insertVal;
            for (int i = 1; i < anArray.Length; i++)
            {
                insertPos = i;
                insertVal = anArray[i];

                while (insertPos > 0 && anArray[insertPos - 1] > insertVal)
                {
                    anArray[insertPos] = anArray[insertPos - 1];
                    insertPos--;
                }
                anArray[insertPos] = insertVal;
            }
        }

        public static void insertion(string[] anArray)
        {
            int insertPos;
            string insertVal;
            for (int i = 1; i < anArray.Length; i++)
            {
                insertPos = i;
                insertVal = anArray[i];

                while (insertPos > 0 && (anArray[insertPos - 1].CompareTo(insertVal) > 0))
                {
                    anArray[insertPos] = anArray[insertPos - 1];
                    insertPos--;
                }
                anArray[insertPos] = insertVal;
            }
        }
    }
}
