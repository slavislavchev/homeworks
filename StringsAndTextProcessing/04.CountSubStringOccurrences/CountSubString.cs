using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSubStringOccurrences
{
    class CountSubString
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string substring = Console.ReadLine();
        int count = CountSubstringsAppearances(input.ToLower(), substring.ToLower());
        Console.WriteLine(count);
    }

    private static int CountSubstringsAppearances(string text, string substring)
    {
        if (substring.Length == 0)
        {
            return 0;
        }
        int count = 0;
        int index = 0;
        while (true)
        {
            index = text.IndexOf(substring, index);
            if (index == -1)
            {
                break;
            }
            else
            {
                count++;
                index++;
            }
        }
        return count;
    }
  }
}
    

