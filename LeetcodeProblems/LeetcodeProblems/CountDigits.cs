
namespace LeetcodeProblems
{
    public static class CountDigits
    {
        public static int evenlyDivides(int n)
        {
            int result = 0;
            int number = n;

            while(n!=0)
            {
                int digit = n % 10;

                if(digit!=0)
                {
                    if(number%digit==0)
                    {
                        result++;
                    }
                }
                n = n / 10;
            }
            return result;
        }
    }
}


/*
number=123

number%10=3
number=number/10;
 
 
*/