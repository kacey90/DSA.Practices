namespace ToptalTests.General
{
    public class PalindromeNumbers
    {
        public bool IsNumberPalindrome(int number)
        {
            int temp = number;
            int remainder, sum = 0;

            while (number > 0)
            {
                remainder = number % 10; //Get the remainder by dividing the number by 10

                sum = (sum * 10) + remainder; // multiply sum by 10 and add the remainder
                number /= 10; // Get the quotient by dividing number by 10.
            }
            if (sum == temp)
                return true;
            return false;
        }
    }
}
