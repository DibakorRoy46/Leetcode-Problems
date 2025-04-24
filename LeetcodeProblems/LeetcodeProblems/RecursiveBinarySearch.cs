

namespace LeetcodeProblems
{
    public class RecursiveBinarySearch
    {
        public static int BinarySearch(int[]nums,int searchNum)
        {
            return FindIndex(nums, searchNum,0,nums.Length-1);
        }

        static int FindIndex(int[]nums,int searchValue,int low,int high)
        {
            if (low > high)
            {
                return -1;
            }
            int mid = (low + (high - low) + 1) / 2;
            if (nums[mid]==searchValue)
            {
                return mid;
            }
            if (searchValue < nums[mid])
            {
                return FindIndex(nums, searchValue, low, mid);
            }
            else
            {
                return FindIndex(nums, searchValue, mid, high);
            }
        }
    }
}
