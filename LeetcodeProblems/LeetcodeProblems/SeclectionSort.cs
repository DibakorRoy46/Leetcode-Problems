

namespace LeetcodeProblems
{
    public static class SeclectionSort
    {
        public static int[] Sort(int[] arr)
        {           
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int min = arr[i];
                for (int j=i;j<=arr.Length-1;j++)
                {
                    if (min > arr[j])
                    {
                        min=arr[j];
                        // Swap the elements
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }               
               }
            }
            return arr;
        }
    }
}
