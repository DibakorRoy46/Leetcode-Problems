
namespace LeetcodeProblems
{
    public static class Sqrt_x__69
    {
        public static int MySqrt(int x)
        {
            if(x == 0) return 0;
            int result = 1;

            for(int i=1;i<x;i++)
            {
                if(i*i<=x)
                {
                    result = i;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}
