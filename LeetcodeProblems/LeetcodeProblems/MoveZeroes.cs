
namespace LeetcodeProblems
{
    public static class MoveZeroes
    {
        public static int[] MoveZerosAtLast(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1) 
                return nums;

            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    int temp=nums[i];
                    nums[i] = nums[index];
                    nums[index] = temp;
                    index++;
                }
            }
            return nums;
        }
    }
}
