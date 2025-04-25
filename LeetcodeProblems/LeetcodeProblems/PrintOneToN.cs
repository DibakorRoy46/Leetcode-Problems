namespace LeetcodeProblems
{
    public static class PrintOneToN
    {
        public static void Print(int n)
        {
            if(n==0)
                return;

            Print(n-1);
            Console.WriteLine(n);
        }
    }

    public static class PrintNToOne
    {
        public static void Print(int n)
        {
            if(n==0) return;

            Console.WriteLine(n);
            Print(n-1);
            
        }
    }
}
