
namespace LeetcodeProblems
{
    public static class ArraySortedOrNot
    {
        public static bool IsSortedOrNot(int[] nums)
        {
            if (nums.Length==0  || nums.Length==1 )
            {
                return true;
            }
            for(int i=0;i<nums.Length-1;i++)
            {
                if (nums[i] > nums[i+1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
