
namespace LeetcodeProblems;

public static class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;

        int[] counts= new int[26];

        for(int i=0 ; i< s.Length ; i++)
        {
           Console.WriteLine(counts[s[i] - 'a']++);
           Console.WriteLine(counts[t[i] - 'a']--);
        }

        foreach (int c in counts)
        {
            if (c != 0) return false;
        }
        return true;
    }
}
