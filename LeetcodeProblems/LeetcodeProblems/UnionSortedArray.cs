

namespace LeetcodeProblems
{
    public static class UnionSortedArray
    {
        public static List<int> UnionArray(List<int> nums1, List<int> nums2)
        {
            if (nums1.Count == 0 && nums2.Count > 1)
                return nums2;

            if (nums1.Count > 0 && nums2.Count == 1)
                return nums1;

            List<int> result = new List<int>();
            int firstIndex = 0;
            int secondIndex = 0;

            while (firstIndex < nums1.Count && secondIndex < nums2.Count)
            {
                if(nums1[firstIndex] < nums2[secondIndex])
                {
                    result.Add(nums1[firstIndex++]);
                }
                else if (nums1[firstIndex] > nums2[secondIndex])
                {
                    result.Add(nums2[secondIndex++]);
                }
                else
                {
                    result.Add(nums1[firstIndex++]);
                    secondIndex++;
                }
            }

            while(firstIndex < nums1.Count )
            {
                result.Add(nums1[firstIndex++]);
            }
            while(secondIndex < nums2.Count)
            {
                result.Add(nums2[secondIndex++]);
            }

            return result;
        }

        public static List<int> FindUnion(int[] nums1, int[] nums2)
        {
            // code here
            if (nums1.Length == 0 && nums2.Length > 1)
                return nums2.ToList();

            if (nums1.Length > 0 && nums2.Length == 0)
                return nums1.ToList();

            List<int> result = new List<int>();
            int firstIndex = 0;
            int secondIndex = 0;

            while (firstIndex < nums1.Length && secondIndex < nums2.Length)
            {
                if (nums1[firstIndex] < nums2[secondIndex])
                {
                    result.Add(nums1[firstIndex++]);
                }
                else if (nums1[firstIndex] > nums2[secondIndex])
                {
                    result.Add(nums2[secondIndex++]);
                }
                else
                {
                    result.Add(nums1[firstIndex++]);
                    secondIndex++;
                }
            }

            while (firstIndex < nums1.Length)
            {
                result.Add(nums1[firstIndex++]);
            }
            while (secondIndex < nums2.Length)
            {
                result.Add(nums2[secondIndex++]);
            }
            HashSet<int> set = new HashSet<int>();

            foreach (int i in result)
            {
                set.Add(i);
            }
            return set.ToList();
        }
    }
}
