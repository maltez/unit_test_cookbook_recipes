using System;

namespace SimpleMvcApplication.Helpers
{
    public class NumHelper
    {
        public long Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return Factorial(number - 1)*number;
        }
    }
}