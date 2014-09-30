using System;

namespace ChapterFourExample
{
    public class Factorial : IDisposable
    {
        public int GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number*GetFactorial(number - 1);
        }

        public void Dispose()
        {
        }
    }
}
