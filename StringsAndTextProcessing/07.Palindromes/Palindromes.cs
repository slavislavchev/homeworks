using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
           
        string inputText = Console.ReadLine();
        char[] delimeter = { ',', ' ', '.', };
        string[] splitinput = inputText.Split(delimeter, 
            StringSplitOptions.RemoveEmptyEntries);

        List<string> palindromes = new List<string>();
        foreach (var item in splitinput)
        {
            if (IsTheWordPalindrom(item) == true)
            {
                palindromes.Add(item);
            }
        }

        foreach (string palindrom in palindromes)
        {
            Console.Write("{0} ", palindrom);
        }
        Console.WriteLine();
    }

    static bool IsTheWordPalindrom(string inputWord)
    {
        bool result = true;
        for (int i = 0; i < inputWord.Length / 2; i++)
        {
            if (inputWord[i] != inputWord[inputWord.Length - i - 1])
            {
                result = false;
            }
        }
        return result;
    }
  }
}

