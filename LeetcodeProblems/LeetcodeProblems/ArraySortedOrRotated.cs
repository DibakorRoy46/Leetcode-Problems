
namespace LeetcodeProblems
{
    public static class ArraySortedOrRotated
    {
        public static bool IsSortedOrRotated(int[] nums)
        {
            if (nums.Length == 0 || nums.Length==1)
            {
                return true;
            }

            int count = 0;
            for(int i=0;i<nums.Length-1;i++)
            {
                if (nums[i] > nums[i+1])
                {
                    count++;
                }
            }
            return count > 1 ? false: (count>=1 && nums[0] < nums[nums.Length-1])?false:true;
        }
    }
}
