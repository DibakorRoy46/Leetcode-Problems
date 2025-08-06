
namespace LeetcodeProblems
{
    public static class ReverseArray
    {
        /// <summary>
        /// This will be the optimzed solution for reversing an array in place.
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        public static int[] Reverse(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return arr;
            }
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                // Swap elements at left and right indices
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                // Move towards the middle
                left++;
                right--;
            }
            return arr;
        }

        /// <summary>
        /// 

        /// This will be the brute force solution for reversing an array.
        /// Time Complexity: O(n)
        /// Space Complexity: O(n)
        private static int[] ReverseBruteForce(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return arr;
            }
            int[] reversedArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversedArray[i] = arr[arr.Length - 1 - i];
            }
            return reversedArray;
        }

        /// <summary>
        /// this will be the recursive solution for reversing an array.
        /// Time Complexity: O(n)
        /// space Complexity: O(n)
        private static int[] ReverseRecursive(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return arr;
            }
            // Swap elements at start and end indices
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            // Recursive call to reverse the next pair
            return ReverseRecursive(arr, start + 1, end - 1);
        }
    }
}
