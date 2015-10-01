using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringLength
{
    class Length
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine().Trim();

            
            string output = input.Length > 20 ? input.Substring(0, 20) : input.PadRight(20, '*');

            
            Console.WriteLine(output);
        }
    }
}
