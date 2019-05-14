using System;
using System.Collections.Generic;
using System.Text;

namespace Solution02
{
    public static class Validations
    {
        public static bool IsInputCorrect(int n)
        {
            if (IsOdd(n) && IsInRange(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsOdd(int n)
        {
            if (n % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool IsInRange(int n)
        {
            if (n >= 3 && n <= 9999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
