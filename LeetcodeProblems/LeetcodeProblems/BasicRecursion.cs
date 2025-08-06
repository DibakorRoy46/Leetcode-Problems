

namespace LeetcodeProblems
{
    public static class BasicRecursion
    {
        public static int NnumbersSum(int N)
        {
            if (N == 0)
                return 0;
            return N + NnumbersSum(N - 1);
        }

        public static int Factorial(int N)
        {
            if (N == 1)
                return 1;
           
            return N *Factorial(N - 1);
        }
    }
}
