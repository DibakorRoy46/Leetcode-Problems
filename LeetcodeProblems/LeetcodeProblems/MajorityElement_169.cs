using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class MajorityElement_169
    {
        //int[] nums = [3, 2, 3,2,2,2];
        public static int MajorityElement(int[] nums)
        {
            return Approch1(nums); 
        }

        public static int Approch1(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                }
                else
                {
                    dic[nums[i]]++;
                }
            }

            int max = 0;
            int result = int.MinValue ;

            foreach (int item in dic.Keys)
            {
                if (dic[item] > max)
                {
                    max = dic[item];
                    result = item;
                }
            }

            return result;
        }


        public static int Approch2(int[] nums)
        {
            int count = 1;
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[index] == nums[i])
                    count++;
                else
                    count--;
                if(count == 0)
                {
                    count = 1;
                    index = i;
                }
            }

            count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[index] == nums[i])
                    count++;
            }

            return count > nums.Length / 2 ? nums[index] : -1;
        }
    }
}
