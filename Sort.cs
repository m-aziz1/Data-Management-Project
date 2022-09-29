namespace Algorithms
{
    public static class Sort
    {
        // Bubble Sort
        public static void bubbleSort(int[] anArray)
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

        public static void bubbleSort(string[] anArray)
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
        public static void selectionSort(int[] anArray)
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

        public static void selectionSort(string[] anArray)
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
        public static void insertSort(int[] anArray)
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

        public static void insertSort(string[] anArray)
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
