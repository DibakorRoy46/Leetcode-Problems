
namespace LeetcodeProblems
{
    public static class BinarySearch
    {
        public static int FindIndex(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (target < nums[mid])
                {
                    high = mid - 1;
                }
                else if (target > nums[mid])
                {
                    low = mid + 1;
                }
                else
                    return mid;

            }
            return -1;
        }
    }
}

