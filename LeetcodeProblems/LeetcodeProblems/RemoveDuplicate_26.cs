
namespace LeetcodeProblems
{
    public static class RemoveDuplicate_26
    {
        public static int RemoveDuplicates(int[] nums)
        {
            return Approch1(nums);
        }

        public static int Approch1(int[] nums)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                nums[i] = list[i];
            }
            return list.Count;
        }

        public static int Approch2(int[] nums)
        {
            //1,2,2,4,5,5,8
            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    int temp=nums[i];
                    nums[i]=nums[j];
                    nums[j]=temp;
                }
            }
            return i;
        }

    }
}
