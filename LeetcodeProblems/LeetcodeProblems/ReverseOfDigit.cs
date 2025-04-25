
using System.Text;

namespace LeetcodeProblems
{
    public static class ReverseOfDigit
    {

        //Approch 1

        public static int Approch1(int number)
        {
            var numberArray=number.ToString().ToArray();

            StringBuilder reverseNumber=new StringBuilder();
            for(int i=numberArray.Length-1; i>=0;i--)
            {
                reverseNumber.Append(numberArray[i]);
            }
            return Convert.ToInt32(reverseNumber.ToString());   
        }

        public static int Approch2(int number)
        {
            int result = 0;

            while (number > 0)
            {
                int digit = number % 10;
                result = result * 10 + digit;
                number /= 10;
            }
            return result;
        }
        //Recursion
        public static int Approch3(int number,int result)
        {
            if(number==0)
                return result;

            int digit = number % 10;
            result = result * 10 + digit;

            return Approch3(number/10, result);
        }
    }
}
