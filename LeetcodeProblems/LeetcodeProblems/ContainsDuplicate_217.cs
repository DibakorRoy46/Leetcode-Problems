

namespace LeetcodeProblems
{
    public static class ContainsDuplicate_217
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            //return Approch1(nums);
            //return Approch2(nums);
            return Approch3(nums);
        }

        //Got Time Limit Exceeded in this Approch
        public static bool Approch1(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j=0;j<nums.Length;j++)
                {
                    if(i != j && nums[i] == nums[j])
                        return true;
                }
            }
            return false;
        }

        public static bool Approch2(int[] nums) 
        {
            HashSet<int> hash = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.Contains(nums[i]))
                {
                    hash.Add(nums[i]);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private static bool Approch3(int[] nums)
        {
            Array.Sort(nums);

            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if(nums[i] == nums[j])
                    return true;
                i++;
            }
            return false;
        }

    }
}
