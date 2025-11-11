

namespace LeetcodeProblems;

public static class ArrayProblems
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        foreach (char c in t)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]--;
                if (charCount[c] < 0)
                    return false;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    public static int[] TowSum(int[] nums ,int target)
    {
        for(int i= 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target && i != j)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { -1, -1 };
    }

    public static int[] TwoSumSolution2(int[] nums, int target)
    {
        Dictionary<int,int> numIndex= new Dictionary<int, int>();
        
        for(int i=0;i<nums.Length;i++)
        {
            int remainging= target - nums[i];
            if(numIndex.ContainsKey(remainging))
            {
                return new int[] { numIndex[remainging], i };
            }
            else
            {
                if(!numIndex.ContainsKey(nums[i]))
                {
                    numIndex.Add(nums[i], i);
                }
            }
        }

        return new int[] { -1, -1 };
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix))
                    return "";
            }
        }
        return prefix;
    }


    public static IList<IList<string>> GroupAnagramsApprochOne(string[] strs)
    {
        Dictionary<string, List<string>> anagramMap = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            char[] charArray = str.ToArray();
            Array.Sort(charArray);

            string strNew = new string(charArray);


            if (anagramMap.ContainsKey(strNew))
            {
                anagramMap[strNew].Add(str);
            }
            else
            {
                anagramMap[strNew] = new List<string> { str };
            }
        }
        return new List<IList<string>>(anagramMap.Values);
    }

    public static IList<IList<string>> GroupAnagramsApprochTwo(string[] strs)
    {
        Dictionary<string, List<string>> anagramMap = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            int[] charCount = new int[26];
            foreach (char c in str)
            {
                charCount[c - 'a']++;
            }
            string key = string.Join(",", charCount);
            if (anagramMap.ContainsKey(key))
            {
                anagramMap[key].Add(str);
            }
            else
            {
                anagramMap[key] = new List<string> { str };
            }
        }
        return new List<IList<string>>(anagramMap.Values);
    }
}
