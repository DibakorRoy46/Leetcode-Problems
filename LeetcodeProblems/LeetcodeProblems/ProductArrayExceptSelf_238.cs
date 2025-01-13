
namespace LeetcodeProblems
{
    public class ProductArrayExceptSelf_238
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            //return Approch1(nums);
            return Approch2(nums);
        }

        public static int[] Approch1(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 1;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        sum *= nums[j];
                    }
                }
                result[i] = sum;
            }
            return result;
        }

        public static int[] Approch2(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            int temp = 1;
            int [] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = temp;
                temp*=nums[i];
            }

            temp = 1;

            for(int i=nums.Length-1; i>=0;i--)
            {
                result[i] *= temp;
                temp*= nums[i];
            }

            return result;

        }

        /*
         Input: nums = [1,2,3,4]
         Output: [24,12,8,6]

        Approch-->1 (Brute Force Approch)

        -->Taking 2 for loops and calculate the value of index without taking this index
        --> Getting Time Limit Exceeded on this solution

        Approch--->2    

        After First Loop Array Like be--> 1,1,2,6
        After Second Loop Array Like be --> [24,12,8,6]

        */
    }
}
