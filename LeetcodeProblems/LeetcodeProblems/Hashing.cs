

namespace LeetcodeProblems
{
    public static class Hashing
    {
        public static Dictionary<int,int> CountingNumber(int[] arr)
        {
            Dictionary<int, int> dic=new Dictionary<int,int>();

            for(int  i=0;i<arr.Length;i++)
            {
                if(!dic.ContainsKey(arr[i]))
                {
                    dic.Add(arr[i], 1);
                }
                else
                {
                    dic[arr[i]]++;
                }
                
            }
            return dic;
        }
    }
}
