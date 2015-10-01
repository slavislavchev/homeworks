using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string reversed = ReverseString(firstString);

            Console.WriteLine(reversed);
        }

        static string ReverseString(string originalString)
        {
            StringBuilder reversedString = new StringBuilder();
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reversedString.Append(originalString[i]);
            }
            return reversedString.ToString();
        }
    }
}
