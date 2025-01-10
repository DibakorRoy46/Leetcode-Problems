
namespace LeetcodeProblems
{
    public static class MoveZeroes_283
    {
        public static void MoveZeroes(int[] nums)
        {
            Approch1(nums);
            Approch2(nums);
        }

        public static void Approch1(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[count];
                    nums[count] = temp;
                    count++;
                }
            }
        }

        public static void Approch2(int[] nums)
        {
            List<int> zeroList = new List<int>();
            List<int> result= new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 )
                {
                    zeroList.Add(0);
                }
                else
                { 
                    result.Add(nums[i]);
                }
            }

            result.AddRange(zeroList);
            for(int i = 0;i < result.Count;i++)
            {
                nums[i] = result[i];
            }
        }

    }
}
