namespace LeetcodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0, 1, 0, 3, 12];
            MoveZeroes_283.MoveZeroes(nums);

            foreach (int i in nums)
            {
                Console.WriteLine(i);   
            }
        }
    }
}
