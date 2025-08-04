

namespace LeetcodeProblems
{
    public static class SecondLargestElement
    {
        public static int Approch1(int[] arr)
        {
            if (arr.Length < 2)
            {
                return -1; // Not enough elements to find the second largest
            }
            int firstLargest = int.MinValue;
            int secondLargest = int.MinValue;
            foreach (int num in arr)
            {
                if (num > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = num;
                }
                else if (num > secondLargest && num < firstLargest)
                {
                    secondLargest = num;
                }
            }
            return secondLargest == int.MinValue ? -1 : secondLargest; // Return -1 if no second largest found
        }

        public static int Approch2(int[] arr)
        {
            if (arr.Length < 2)
            {
                return -1; // Not enough elements to find the second largest
            }
            Array.Sort(arr);
            int firstLargest = arr[arr.Length - 1];
            int secondLargest = int.MinValue;
            foreach (var item in arr)
            {
                if(item < firstLargest)
                {
                    secondLargest = item;
                    break; // Found the second largest, exit loop
                }
            }
            return secondLargest == int.MinValue ? -1 : secondLargest; // Return -1 if no second largest found
        }
    }
}
