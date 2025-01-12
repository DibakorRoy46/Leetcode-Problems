namespace LeetcodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region MoveZeros 283

            //int[] nums = [0, 1, 0, 3, 12];
            //MoveZeroes_283.MoveZeroes(nums);

            #endregion

            #region Majority Element 169
            //int[] nums = [3, 2, 3];
            //int result=MajorityElement_169.MajorityElement(nums);

            //Console.WriteLine(result);

            #endregion

            #region Remove Duplicates from Sorted Array 26

            //int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            //Console.WriteLine(RemoveDuplicate_26.RemoveDuplicates(nums));

            #endregion

            #region 121. Best Time to Buy and Sell Stock

            int[] nums = [7, 1, 5, 3, 6, 4];
            Console.WriteLine(BestTimeBuySellStock_121.MaxProfit(nums));

            #endregion


        }
    }
}
