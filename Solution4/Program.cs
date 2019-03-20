using System;
using System.Text;

namespace Solution4
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
            int len = str.Length - num;
            return new StringBuilder(str, 0, len, len).ToString();
        }
    }
}
