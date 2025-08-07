
namespace LeetcodeProblems
{
    public static class BubbleSortAlgorithm
    {
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        public static int[] BubbleSortUsingRecursion(int[] arr, int r, int c)
        {
            // Base case: If the array is of size 1 or less, it's already sorted
            if (arr.Length == 1)
                return arr;
            // If we have completed one pass, reduce the

            if (r > 0)
            {
                // If we have completed one pass, reduce the
                if (c < r)
                {
                    // Compare adjacent elements and swap if needed
                    if (arr[c] > arr[c + 1])
                    {
                        // Swap
                        int temp = arr[c];
                        arr[c] = arr[c + 1];
                        arr[c + 1] = temp;
                    }
                    // Move to the next pair
                    BubbleSortUsingRecursion(arr, r, c + 1);
                }
                else
                {
                    // Move to the next pass
                    BubbleSortUsingRecursion(arr, r - 1, 0);
                }
            }
            return arr;
        }

    }
}
