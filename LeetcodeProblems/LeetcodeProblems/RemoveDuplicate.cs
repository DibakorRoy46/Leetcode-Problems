
namespace LeetcodeProblems
{
    public static class RemoveDuplicate
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if(nums.Length==0 || nums.Length==1)
            {
                return nums.Length;
            }
            int index = 1;
            for(int i=1;i<nums.Length;i++)
            {
                if (nums[i] != nums[i-1])
                {
                    int temp= nums[i];
                    nums[i]=nums[i-1];
                    nums[i-1]=temp;
                    index++;
                }
            }
            return index;
        }
    }
}
