

namespace LeetcodeProblems
{
    public static class Recursion
    {
        public static int SumOnetoN(int n)
        {
            if (n == 1)
                return 1;

            return n + SumOnetoN(n - 1);
        }

        public static int ProductOnetoN(int n)
        {
            if (n == 1)
                return 1;

            return n * ProductOnetoN(n - 1);
        }
    }
}
