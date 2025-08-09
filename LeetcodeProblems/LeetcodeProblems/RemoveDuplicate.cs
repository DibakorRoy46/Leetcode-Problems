
namespace LeetcodeProblems
{
    public static class RemoveDuplicate
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return nums.Length;
            }
            int index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[index])
                {
                    index++;
                    int temp = nums[i];
                    nums[i] = nums[index];
                    nums[index] = temp;
                }
            }
            return index + 1;
        }

        public static int RemoveDuplicatesUsingDictonary(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return nums.Length;
            }

            Dictionary<int, int> uniqueNumbers = new Dictionary<int, int>();    
            int count=0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(!uniqueNumbers.ContainsKey(nums[i]))
                {
                    uniqueNumbers.Add(count, nums[i]);
                    count++;
                }
            }

            for (int i = 0; i < uniqueNumbers.Count; i++)
            {
                nums[i] = uniqueNumbers[i];
            }

            return uniqueNumbers.Count+1;

        }
    }

}
