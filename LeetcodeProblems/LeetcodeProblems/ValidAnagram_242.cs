
using System.Reflection.Metadata;

namespace LeetcodeProblems
{
    public static class ValidAnagram_242
    {
        public static bool IsAnagram(string s, string t)
        {
            return Approch1(s,t);
        }

        public static bool Approch1(string s, string t)
        {
            if(s.Length!=t.Length)
                return false;

            Dictionary<char,int> dict = new Dictionary<char,int>();

            for(int i=0;i<s.Length;i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 1);
                else 
                    dict[s[i]]++;
            }

            for(int i=0;i<t.Length;i++)
            {
                if (!dict.ContainsKey(t[i]))
                    return false;
                else
                    dict[t[i]]--;
            }


            foreach(char c in dict.Keys)
            {
                if (dict[c]>0)
                    return false;
            }
            return true;
        }
    }
}
