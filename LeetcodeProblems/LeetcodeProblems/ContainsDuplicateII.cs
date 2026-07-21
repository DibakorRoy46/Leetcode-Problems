namespace LeetcodeProblems;
using System.Collections.Generic;
public class ContainsDuplicateII
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int , int> dic = new Dictionary<int , int>();

        for(int i = 0; i < nums.Length; i++) 
        {
            if (dic.ContainsKey(nums[i]))
            {
                if(Math.Abs(dic[nums[i]] - i)<=k)
                    return true;

                dic[nums[i]] = Math.Max(dic[nums[i]], i);
            }
            else
            {
                dic.Add(nums[i], i);
            }
        }

        return false;
    }
}
