
namespace LeetcodeProblems
{
    public static class BestTimeBuySellStock_121
    {
        //[7,1,5,3,6,4]
        public static int MaxProfit(int[] prices)
        {
            return Approch1(prices);
        }
        //This Got TLE in LeetCode
        public static int Approch1(int[] prices)
        {
            int result = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    result=Math.Max(result, prices[j] - prices[i]);
                }
            }
            return result;
        }
        public static int Approch2(int[] prices)
        {
            int min=0;
            int result = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if(prices[i] <= prices[min])
                {
                    min = i;
                }
                else
                {
                    result=Math.Max(result, prices[i]- prices[min]);
                }
            }
            return result;
        }
    }
}
