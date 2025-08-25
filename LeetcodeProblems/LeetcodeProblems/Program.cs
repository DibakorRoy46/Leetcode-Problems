namespace LeetcodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 3, 2, 5, 2, 6, 2, 1 };

            #region 283. MoveZeros

            //int[] nums = [0, 1, 0, 3, 12];
            //MoveZeroes_283.MoveZeroes(nums);

            #endregion

            #region 169. Majority Element 
            //int[] nums = [3, 2, 3];
            //int result=MajorityElement_169.MajorityElement(nums);

            //Console.WriteLine(result);

            #endregion

            #region 26. Remove Duplicates from Sorted Array 

            //int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            //Console.WriteLine(RemoveDuplicate_26.RemoveDuplicates(nums));

            #endregion

            #region 121. Best Time to Buy and Sell Stock

            //int[] nums = [7, 1, 5, 3, 6, 4];
            //Console.WriteLine(BestTimeBuySellStock_121.MaxProfit(nums));

            #endregion

            #region 189. Rotate Array

            //int[] nums = [1, 2, 3, 4, 5, 6, 7];
            ////int[] nums = [-1, -100, 3, 99];
            ////int[] nums = [1, 2];
            //int k = 3;
            //RotateArray_189.Rotate(nums, k);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //   Console.WriteLine(nums[i]);
            //}

            #endregion

            #region 238. Product of Array Except Self

            //int[] nums = [1, 2, 3, 4];
            ////int[] nums = [-1, 1, 0, -3, 3];
            //var result=ProductArrayExceptSelf_238.ProductExceptSelf(nums);

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);            
            //}

            #endregion

            #region 217. Contains Duplicate

            //int[] nums = { 1, 2, 3, 4, 5, 6, 6 };

            //Console.WriteLine(ContainsDuplicate_217.ContainsDuplicate(nums));

            #endregion

            #region 242. Valid Anagram


            #endregion

            #region 69. Sqrt(x)

            //int number = 8;
            //Console.WriteLine(Sqrt_x__69.MySqrt(number));

            #endregion

            #region Linear Search

            //int[] nums = { 2, 3, 4, 5, 1, 47, 84 };
            //int target = 4;

            //Console.WriteLine(LinearSearch.FindIndex(nums, target));

            #endregion

            #region Binary Search

            //int[] nums = { 2, 3, 4, 5, 7,10,56,99};
            //int target = 4;

            //Console.WriteLine(BinarySearch.FindIndex(nums,target));

            #endregion

            #region Order Agnostic Binary Search

            //int[] nums = { 2, 3, 4, 5, 7, 10, 56, 99 };
            //int[] nums = { 99,56,10,7,5,4,3,2 };
            //int target = 4;

            //Console.WriteLine(OrderAgnosticBinarySearch.FindIndex(nums, target));

            #endregion

            #region Count Digit

            //int number = 12;
            //Console.WriteLine(CountDigits.evenlyDivides(number));

            #endregion

            #region Recursive Binary Search


            //int[] nums = { 2, 3, 4, 5, 7, 10, 56, 99 };
            //int target = 4;

            //Console.WriteLine(BinarySearch.FindIndex(nums, target));


            //Console.WriteLine(RecursiveBinarySearch.BinarySearch(nums, target));

            #endregion

            #region Print One To N

            //PrintOneToN.Print(5);

            #endregion

            #region Print One To N

            //PrintNToOne.Print(5);

            #endregion

            #region Recursion Introduction

            //Console.WriteLine(Recursion.SumOnetoN(5));
            //Console.WriteLine(Recursion.ProductOnetoN(5));

            #endregion

            #region Sum & Product of Digit

            //Console.WriteLine(Sum_ProductOfDigit.SumOfDigit(12345));
            //Console.WriteLine(Sum_ProductOfDigit.SumOfDigitRecusion(12345));
            //Console.WriteLine(Sum_ProductOfDigit.ProuuctOfDigit(12345));
            //Console.WriteLine(Sum_ProductOfDigit.ProductOfDigitRecusion(12345));

            #endregion

            #region ReverseDigit

            //Console.WriteLine(ReverseOfDigit.Approch1(12345));
            //Console.WriteLine(ReverseOfDigit.Approch2(12345));
            //Console.WriteLine(ReverseOfDigit.Approch3(12345, 0));


            #endregion

            #region Bubble Sort

            //var result=BubbleSort.BubbleSortUsingLoop(nums);
            //foreach (int i in result) 
            //{
            //    Console.Write(i +" ");
            //}
            //BubbleSort.BubbleSortUsingRecursion(nums,nums.Length-1,0);
            //Console.WriteLine();    
            //foreach (int i in nums)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region Second Largest Element

            //int result = SecondLargestElement.Approch1(nums);
            ////int result = SecondLargestElement.Approch2(nums);
            //Console.WriteLine(result);

            #endregion

            #region Rotate Array

            //nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            //var result=RotateArray.Rotate(nums, 3);
            //result=RotateArray.Rotate2(nums, 3);
            //foreach (int i in result)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Basic Recursion

            //int n = 4;
            ////Console.WriteLine(BasicRecursion.NnumbersSum(n));
            //Console.WriteLine(BasicRecursion.Factorial(n));

            #endregion

            #region Counting Number Frequencies

            //var result= Hashing.CountingNumber(nums);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key+"-->"+item.Value);
            //}

            #endregion

            #region Selection Sort

            //nums = new int[] { 10, 30, 3, 4, 1, 11 };
            //var result = SeclectionSort.Sort(nums);

            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");    
            //}

            #endregion

            #region Bubble Sort

            //nums = new int[] { 10, 30, 3, 4, 1, 11 };
            ////var result = BubbleSortAlgorithm.BubbleSort(nums);
            //var result = BubbleSortAlgorithm.BubbleSortUsingRecursion(nums,nums.Length-1,0);

            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Array Sorted or Rotated

            //nums = new int[] { 2, 1, 3, 4 };
            //Console.WriteLine(ArraySortedOrRotated.IsSortedOrRotated(nums));

            #endregion

            #region Remove Duplicates from Sorted Array

            //nums= new int[] { 1,1,2 };

            //Console.WriteLine(RemoveDuplicate.RemoveDuplicatesUsingDictonary(nums));

            #endregion

            #region Move Zeros

            //nums = new int[] { 0, 1, 0, 3, 12 };
            //var result=MoveZeroes.MoveZerosAtLast(nums);

            //foreach (int i in nums)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region Union Two Sorted Array

            //List<int> nums1 = new List<int>() { 2, 2, 4, 6, 6, 8 };
            //List<int> nums2 = new List<int>() { 4, 4, 6 };

            //var result=UnionSortedArray.FindUnion(nums1.ToArray(), nums2.ToArray());


            #endregion

            #region Longest SubArray Sum With K
            //nums = new int[] { 10, 5, 2, 7, 1, -10 };
            //int k = 15;

            //Console.WriteLine(LongestSubarraywithSumK.FindLongestSubarratSumOptimal(nums, k));

            #endregion

            #region Singly Linked List

            //SinglyLinkedList linkedList = new SinglyLinkedList();
            //linkedList.Add(10);
            //linkedList.Add(20);
            //linkedList.Add(30);

            //linkedList.PrintList();


            #endregion

            #region Linked List Details

            LinkeList linkedList = new LinkeList();
            linkedList.InsertionInLastPosition(10);
            linkedList.InsertionInLastPosition(20);
            linkedList.InsertionInLastPosition(30);
            linkedList.InsertionInLastPosition(40);
            linkedList.InsertionInFirstPosition(50);
            linkedList.InsertionInSpecificPosition(60,3);

            linkedList.DisplayLinkedList();


            #endregion
        }

    }
}
