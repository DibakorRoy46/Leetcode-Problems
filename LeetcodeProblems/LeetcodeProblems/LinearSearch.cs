
namespace LeetcodeProblems
{
    public static class LinearSearch
    {
        public static int FindIndex(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++) 
            { 
                if(nums[i] == target)
                    return i;
            }
            return -1;
        }
    }
}
