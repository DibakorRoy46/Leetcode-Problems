
namespace LeetcodeProblems
{
    public static class OrderAgnosticBinarySearch
    {
        public static int FindIndex(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            bool isAsc = false;
            if (nums[low] < nums[high])
            {
                isAsc = true;
            }

            while (low <= high)
            {
                int mid=low + (high - low)/2;

                if(nums[mid] ==target)
                    return mid;

                if(isAsc)
                {
                    if(target < nums[mid])
                    {
                        high = mid - 1;
                    }
                    else if(target > nums[mid])
                    {
                        low = mid + 1;
                    }
                }
                else
                {
                    if (target < nums[mid])
                    {
                        low = mid + 1;                  
                    }
                    else if (target > nums[mid])
                    {
                        high = mid - 1;
                    }
                }
            }
            return -1;
        }
    }    
}
