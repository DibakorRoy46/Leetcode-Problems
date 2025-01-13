
namespace LeetcodeProblems
{
    public static class RotateArray_189
    {
        public static void Rotate(int[] nums, int k)
        {
            //Approch1(nums, k);
            Approch2(nums, k);
        }

        public static void Approch1(int[] nums, int k)
        {
            if (nums.Count() < k)
                k= nums.Count();

            List<int> firstPhase= new List<int>();
            List<int> lastPhase= new List<int>();
            
            for (int i = nums.Length - k; i <nums.Length; i++)
            {
                firstPhase.Add(nums[i]);
            }
            for (int i = 0; i < nums.Length-k; i++)
            {
                lastPhase.Add(nums[i]);
            }

            firstPhase.AddRange(lastPhase);

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = firstPhase[i];
            }
        }


        public static void Approch2(int[] nums, int k)
        {
            k=k%nums.Length;    

            Reverse(nums,0,nums.Length-1-k);
            Reverse(nums,nums.Length-k,nums.Length-1);
            Reverse(nums,0,nums.Length-1);
        }

        public static void Reverse(int[] nums, int min, int max)
        {
            while (min <= max)
            {
                int temp = nums[min];
                nums[min] = nums[max];
                nums[max] = temp;
                min++;
                max--;
            }
        }

        /*
        
        [1, 2, 3, 4, 5, 6, 7]
        [4,3,2,1] [7,6,5]



        */
    }
}
