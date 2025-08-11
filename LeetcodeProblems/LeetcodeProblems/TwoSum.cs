
namespace LeetcodeProblems
{
    public static class TwoSum
    {
        public static int[] FindTwoSum(int[] nums,int target)
        {
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for(int i=0;i<nums.Length;i++)
            {
                int needValue=target - nums[i];
                if(numIndices.ContainsKey(needValue))
                {
                    return new int[] { numIndices[needValue], i };
                }
                else if(!numIndices.ContainsKey(nums[i]))
                {
                    numIndices[nums[i]] = i;
                }
            }
            return new int[] { -1, -1 }; // Return -1, -1 if no solution is found
        }

        public static int[] FindTwoSum_2(int[] nums, int target)
        {
            for(int i=0;i<nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    
                    if(i!=j && nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { -1, -1 }; // Return -1, -1 if no solution is found
        }
    }
}
