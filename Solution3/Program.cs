using System;

namespace Solution3
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
            return str.Substring(0, str.Length - num);
        }
    }
}
