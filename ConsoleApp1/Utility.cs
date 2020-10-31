using System.Collections.Generic;

namespace ConsoleApp1
{
    class Utility
    {
        public static IEnumerable<char> BusySymbols()
        {
            var busySymbols = @"-\|/-\|/";
            int next = 0;
            while (true)
            {
                yield return busySymbols[next];
                next = (next + 1) % busySymbols.Length;
                yield return '\b';
            }
        }
    }
}
