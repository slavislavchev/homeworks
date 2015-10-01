using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.ExtractEmails
{
    class ExtractEmai
    {
        static void Main(string[] args)
        {
            string sampleText = Console.ReadLine();
            string pattern = @"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})";

            MatchCollection results = Regex.Matches(sampleText, pattern);
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}

     
