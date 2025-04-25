
namespace LeetcodeProblems
{
    public static class Sum_ProductOfDigit
    {
        public static int SumOfDigit(int number)
        {
            int result = 0;

            while(number>0)
            {
                int digit = number % 10;
                result += digit;
                number /= 10;
            }
            return result;
        }

        public static int SumOfDigitRecusion(int number)
        {
            if(number==0)
                return 0;

            int digit = number % 10;

            return digit + SumOfDigitRecusion(number / 10);
        }

        public static int ProuuctOfDigit(int number)
        {
            int result = 1;

            while (number > 0)
            {
                int digit = number % 10;
                result *= digit;
                number /= 10;
            }
            return result;
        }

        public static int ProductOfDigitRecusion(int number)
        {
            if (number == 0)
                return 1;

            int digit = number % 10;

            return digit * ProductOfDigitRecusion(number / 10);
        }

    }
}
