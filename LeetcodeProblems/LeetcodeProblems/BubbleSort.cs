

namespace LeetcodeProblems
{
    public static class BubbleSort
    {
        public static int[] BubbleSortUsingLoop(int[] nums)
        {
            int length = nums.Length;
            bool isSwap = false;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                        isSwap = true;
                    }
                }
                if (!isSwap)
                    break;
            }
            return nums;
        }

        public static void BubbleSortUsingRecursion(int[] nums,int r,int c) 
        {
            if (r == 0)
                return;

            if (c < r)
            {
                if (nums[c] > nums[c + 1])
                {
                    int temp = nums[c];
                    nums[c] = nums[c + 1];
                    nums[c + 1] = temp;
                }
                BubbleSortUsingRecursion(nums, r, c + 1);
            }
            else 
            {
                BubbleSortUsingRecursion(nums, r - 1, 0);
            }          
        }
    }
}
