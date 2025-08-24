

namespace LeetcodeProblems
{
    public static class LongestSubarraywithSumK
    {
        //Using Brute Force Approach
        public static int FindLongestSubarratSum(int[] arr,int k)
        {
            int maxLength = 0;
            int currentSum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                currentSum = 0;
                for(int j=i;j<arr.Length;j++)
                {
                    currentSum += arr[j];
                    if(currentSum == k)
                    {
                        maxLength = Math.Max(maxLength, j-i+1);
                    }
                }
            }

            return maxLength;
        }

        public static int FindLongestSubarratSumOptimal(int[] arr, int k)
        {
            int maxLength = 0;
            int currentSum = 0;
            Dictionary<int, int> sumIndices = new Dictionary<int, int>();
            sumIndices[0] = -1;
            for(int i=0;i<arr.Length;i++)
            {
                currentSum += arr[i];
                if(!sumIndices.ContainsKey(currentSum))
                {
                    sumIndices[currentSum] = i;
                }
                if(sumIndices.ContainsKey(currentSum - k))
                {
                    maxLength = Math.Max(maxLength, i - sumIndices[currentSum - k]);
                }
            }
            return maxLength;
        }
    }
}
