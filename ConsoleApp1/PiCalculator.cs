using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    class PiCalculator
    {
        public static string Calculate(int digits = 100)
        {
            var res = 0;
            for (int i = 0; i < Math.Pow(100,4); i++)
            {
                res += i;
            }

            return res.ToString();
        }
    }
}
