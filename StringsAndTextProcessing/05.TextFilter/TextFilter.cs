using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a banned words:");
        string input = Console.ReadLine();
        string[] banned = input.Split(',');

        Console.WriteLine("Enter a string:");
        input = Console.ReadLine();


        string[] words = new string[banned.Length];
        for (int i = 0; i < banned.Length; i++)
        {
            StringBuilder sb = new StringBuilder(banned[i].Length);

            for (int p = 0; p < banned[i].Length; p++)
            {
                sb.Append('*');
            }
            words[i] = sb.ToString();
        }
        for (int i = 0; i < banned.Length; i++)
        {
            input = input.Replace(banned[i], words[i]);
        }
        Console.WriteLine(input);
    }
  }
}
    

