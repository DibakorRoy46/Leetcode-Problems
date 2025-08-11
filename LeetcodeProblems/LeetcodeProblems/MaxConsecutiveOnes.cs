

namespace LeetcodeProblems
{
    public static class MaxConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    max=Math.Max(max, count);
                    count = 0; // Reset count when a 0 is encountered
                }
            }
            max = Math.Max(max, count); // Check at the end in case the array ends with 1s
            return max;
        }
    }
}
