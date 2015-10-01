using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _03.ReplaceTag
{
    class Tag
    {
        static void Main(string[] args)
        {
            string source = Console.ReadLine();
            Console.WriteLine(ParseHTML(source));
        }

        static string ParseHTML(string htmlSource)
        {
            string pattern = @"<a.href=""([^>]*)"">([^<]*(?:(?!</a)<[^<]*)*)</a>";
            return Regex.Replace(htmlSource, pattern, "[URL=$1]$2[/URL]");
        }
    }
}

    

