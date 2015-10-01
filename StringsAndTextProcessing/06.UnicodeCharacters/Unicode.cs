using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UnicodeCharacters
{
    class Unicode
    {
        static void Main(string[] args)
        {

        string input = Console.ReadLine();
        int[] transform = new int[input.Length];
        StringBuilder converted = new StringBuilder();
        string unicode;
        for (int index = 0; index < transform.Length; index++)
        {
            transform[index] = input[index];
            unicode = string.Format(@"\u{0:x4}", transform[index]);
            converted.Append(unicode);
        }
        Console.WriteLine(converted.ToString());
    }
  }
}
    

