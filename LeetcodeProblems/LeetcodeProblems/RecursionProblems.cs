
namespace LeetcodeProblems;

internal class RecursionProblems
{
    public static void PrintNToOne(int n)
    {
        if (n == 0)
            return;
        Console.WriteLine(n);
        PrintNToOne(n - 1);
    }

    public static void PrintOneToN(int n)
    {
        if(n==0)
            return;
        PrintOneToN(n - 1);
        Console.WriteLine(n);
    }

    public static int ProductOneToN(int n)
    {
        if(n==1)
            return 1;
        return n * ProductOneToN(n-1);
    }

    public static int SumOfOneToN(int n)
    {
        if(n==1)
            return 1;
        return n + SumOfOneToN(n-1);
    }

    public static int ProductOfDigit(int n)
    {
        if(n==0)
            return 1;

        return (n%10) * ProductOfDigit(n / 10);
    }

    public static int ProductOfDigitWithPassingNumber(int n, int product)
    {
        if(n==0)
            return product;
        return ProductOfDigitWithPassingNumber(n / 10, product * (n % 10));
    }

    public static int ReverseANumber(int n)
    {
        if(n==0)
            return 0;
        int digits = (int)Math.Floor(Math.Log10(n)) + 1;
        return (n % 10) * (int)Math.Pow(10, digits - 1) + ReverseANumber(n / 10);
    }

    public static bool IsPalindrome(int num)
    {
        if(num<0)
            return false;
        if(num>=0 && num<10)
            return true;

        return num == ReverseANumber(num);
    }

    public static int CountNumberOfZeros(int n)
    {
        if (n == 0)
            return 0;
        
        return n%10== 0 ? 1 + CountNumberOfZeros(n / 10) : CountNumberOfZeros(n / 10);
    }
    public static int NumberOfSteps(int num)
    {
        if(num==0)
            return 0;
        return (num % 2==0?1+ NumberOfSteps(num / 2):1+NumberOfSteps(num-1) );
    }

    public static int NumberOfSteps(int num,int result)
    {
        if (num == 0)
            return result;
        return (num % 2 == 0 ?  NumberOfSteps(num / 2,result+1) : NumberOfSteps(num - 1, result + 1));
    }
}
