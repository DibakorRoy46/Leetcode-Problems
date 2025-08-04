
namespace LeetcodeProblems
{
    public static class RotateArray
    {
        /*
        this will be my first approach to solve the problem
        Time Complexity: O(n)
        Space Complexity: O(1)

        in first step i have to reverse the entire array 
        after this step array will be like this==> 7,6,5,4,3,2,1

        in second step i have to reverse the array from 0 to k-1
        after this step array will be like this==> 5,6,7,4,3,2,1

        in third step i have to reverse the array from k to n-1
        after this step array will be like this==> 5,6,7,1,2,3,4
      
        */
        public static int[] Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; // Handle cases where k is greater than n
            Reverse(nums, 0, n - 1); // Reverse the entire array
            Reverse(nums, 0, k - 1); // Reverse the first k elements
            Reverse(nums, k, n - 1); // Reverse the remaining elements            
            return nums;
        }
        private static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        //2nd approch
        /*1,2,3,4,5,6,7 and k=3     
        n=7;
        algorithm: (k+loop value)%lenght of array= num[loop value]
        itaration ==>    3%7 = 3==1
        itaration ==>    4%7 = 4==2
        itaration ==>    5%7 = 5==3
        itaration ==>    6%7 = 6==4
        itaration ==>    7%7 = 0==5
        itaration ==>    8%7 = 1==6
        itaration ==>    9%7 = 2==7     

        Time Complexity: O(n)
        Space Complexity: O(n)
        */

        public static int[] Rotate2(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; // Handle cases where k is greater than n
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[(i + k) % n] = nums[i];
            }
            return result;
        }
    }
}
