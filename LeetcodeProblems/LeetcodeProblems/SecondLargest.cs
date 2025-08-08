

namespace LeetcodeProblems
{
    public static class SecondLargest
    {
        public static int FindSecondLargestElement(int[] nums)
        {
            if(nums.Length==0 || nums.Length==1)
            {
                return -1; // Not enough elements to find the second largest
            }
            int firstLargest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = nums[i];
                }

                if (nums[i]>secondLargest && nums[i]< firstLargest)
                {
                    secondLargest = nums[i];
                }
            }

            return secondLargest == int.MinValue ? -1 : secondLargest; // Return -1 if no second largest found
        }
    }
}
