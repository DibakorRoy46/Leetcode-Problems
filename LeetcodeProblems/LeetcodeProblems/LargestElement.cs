
namespace LeetcodeProblems
{
    public static class LargestElement
    {
        public static int FoundLargestElement(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            int largest = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > largest)
                {
                    largest = nums[i];
                }
            }
            return largest;
        }
    }
}
