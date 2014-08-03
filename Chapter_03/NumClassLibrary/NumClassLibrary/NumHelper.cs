using System;

namespace NumClassLibrary
{
    public class NumHelper
    {
        public long Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                    string.Format("Factorial of negative number is undefined. You input value {0}", number));
            }

            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
