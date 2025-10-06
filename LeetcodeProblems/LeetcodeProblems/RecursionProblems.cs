
namespace LeetcodeProblems;

internal class RecursionProblems
{
    public static void PrintNToOne(int n)
    {
        if (n == 0)
            return;
        Console.WriteLine(n);
        PrintNToOne(n - 1);
    }

    public static void PrintOneToN(int n)
    {
        if(n==0)
            return;
        PrintOneToN(n - 1);
        Console.WriteLine(n);
    }

    public static int ProductOneToN(int n)
    {
        if(n==1)
            return 1;
        return n * ProductOneToN(n-1);
    }

    public static int SumOfOneToN(int n)
    {
        if(n==1)
            return 1;
        return n + SumOfOneToN(n-1);
    }

    public static int ProductOfDigit(int n)
    {
        if(n==0)
            return 1;

        return (n%10) * ProductOfDigit(n / 10);
    }

    public static int ProductOfDigitWithPassingNumber(int n, int product)
    {
        if(n==0)
            return product;
        return ProductOfDigitWithPassingNumber(n / 10, product * (n % 10));
    }

    public static int ReverseANumber(int n)
    {
        if(n==0)
            return 0;
        int digits = (int)Math.Floor(Math.Log10(n)) + 1;
        return (n % 10) * (int)Math.Pow(10, digits - 1) + ReverseANumber(n / 10);
    }

    public static bool IsPalindrome(int num)
    {
        if(num<0)
            return false;
        if(num>=0 && num<10)
            return true;

        return num == ReverseANumber(num);
    }

    public static int CountNumberOfZeros(int n)
    {
        if (n == 0)
            return 0;
        
        return n%10== 0 ? 1 + CountNumberOfZeros(n / 10) : CountNumberOfZeros(n / 10);
    }
    public static int NumberOfSteps(int num)
    {
        if(num==0)
            return 0;
        return (num % 2==0?1+ NumberOfSteps(num / 2):1+NumberOfSteps(num-1) );
    }

    public static int NumberOfSteps(int num,int result)
    {
        if (num == 0)
            return result;
        return (num % 2 == 0 ?  NumberOfSteps(num / 2,result+1) : NumberOfSteps(num - 1, result + 1));
    }

    public static bool IsArraySortedOrNot(int[] arr, int index)
    {
        if(index==arr.Length-1)
            return true;
        return arr[index]<=arr[index+1] && IsArraySortedOrNot(arr,index+1);
    }

    public static bool LinearSearchUsingRecursion(int[] nums,int target,int index)
    {
        if(index==nums.Length)
            return false;
        if(nums[index]==target)
            return true;

        return LinearSearchUsingRecursion(nums,target,index+1);
    }

    public static int LinearSearchIndexUsingRecursion(int[] nums, int target, int index)
    {
        if (index == nums.Length)
            return -1;
        if (nums[index] == target)
            return index;

        return LinearSearchIndexUsingRecursion(nums, target, index + 1);
    }

    public static List<int> FindAllIndexUsingRecusion(int[] nums,int target,int index,List<int>result)
    {
        if (index == nums.Length)
            return result;
        if (nums[index]==target)
            result.Add(index);
        return FindAllIndexUsingRecusion(nums, target, index + 1,result);
    }

    public static List<int> FindAllIndexUsingRecusion2(int[] nums, int target, int index)
    {
        List<int> result = new List<int>();
        if (index == nums.Length)
            return result;
        if (nums[index] == target)
            result.Add(index);
        List<int> ansFromBelowCalls = FindAllIndexUsingRecusion2(nums, target, index + 1);
        result.AddRange(ansFromBelowCalls);
        return result;
    }

    public int RoatedBinarySearch(int[] nums,int target,int start,int end)
    {
        if(start>end)
            return -1;

        int mid=start + (end - start) / 2;

        if(nums[mid]== target)
            return mid;

        if(nums[start] <= nums[mid])
        {
            if (nums[start]<= target && target <= nums[mid])
            {
                return RoatedBinarySearch(nums, target, start, mid - 1);
            }
            else
            {
                 return RoatedBinarySearch(nums, target, mid + 1, end);
            }
        }

        if(target>=nums[mid] && target <= nums[end])
        {
            return RoatedBinarySearch(nums, target, mid + 1, end);
        }

        return RoatedBinarySearch(nums, target, start, mid - 1);
    }

    public static void PrintPatternOne(int r ,int c)
    {
        if(r==0)
            return;
        if(c<r)
        {
            Console.Write("*");
            PrintPatternOne(r,c+1);
        }
        else
        {
            Console.WriteLine();
            PrintPatternOne(r-1,0);
        }
    }

    public static void PrintPatternTwo(int r, int c)
    {
        if (r == 0)
            return;
        if (c < r)
        {
            PrintPatternTwo(r, c + 1);
            Console.Write("*");
        }
        else
        {
            PrintPatternTwo(r - 1, 0);
            Console.WriteLine();
        }
    }

    public static void BubbleSortUsingRecursion(int[] arr, int r, int c)
    {
        if (r == 0)
            return;

        if (c < r)
        {
            if (arr[c] > arr[c + 1])
            {
                int temp = arr[c];
                arr[c] = arr[c + 1];
                arr[c + 1] = temp;
            }
            BubbleSortUsingRecursion(arr, r, c + 1);
        }
        else
        {
            BubbleSortUsingRecursion(arr, r - 1, 0);
        }
    }

    public static void SelectionSortUsingRecursion(int[] arr, int r, int c, int max)
    {
        if (r == 0)
            return;
        if (c < r)
        {
            if (arr[c] > arr[max])
                SelectionSortUsingRecursion(arr, r, c + 1, c);
            else
                SelectionSortUsingRecursion(arr, r, c + 1, max);
        }
        else
        {
            int temp = arr[max];
            arr[max] = arr[r - 1];
            arr[r - 1] = temp;
            SelectionSortUsingRecursion(arr, r - 1, 0, 0);
        }
    }
}
