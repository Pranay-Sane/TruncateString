using System;
using System.Linq;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TruncateString("hello", 2));
        }

        static string TruncateString(string str, int num)
        {
            if (str.Length <= num) return str;
            return string.Concat(str.Take(str.Length - num));
        }
    }
}
